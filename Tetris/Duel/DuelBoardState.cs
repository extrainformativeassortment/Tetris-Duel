using System.Collections.Concurrent;
using System.Diagnostics;
using Tetris.Blocks;
using Tetris.BoardGroup;

namespace Tetris.Duel
{
    internal class DuelBoardState(int Id, Label comboTypeLabel, Label clearTypeLabel) : BoardState
    {
        public override BoardGrid BoardGrid { get; protected set; } = new DuelBoardGrid(27, 10);
        public DuelBoardGrid DuelBoardGrid => (DuelBoardGrid)BoardGrid;
        private readonly int Id = Id;
        public DuelBoardState Opponent { get; set; }

        private int linesCleared, combo;
        private bool clearedTetris;

        private Label comboType = comboTypeLabel, clearType = clearTypeLabel;

        private int garbageLinesToAdd;

        private void bugcheck()
        {
            for (int r = 0; r < DuelBoardGrid.rows; r++)
            {
                for (int c = 0; c < DuelBoardGrid.columns; c++)
                {
                    Debug.Write($"{DuelBoardGrid.grid[r, c]} ");
                }
                Debug.Write($"\n");
            }
        }

        protected override void PlaceBlock()
        {
            bool hitBomb = false;

            foreach (Position p in currentBlock.TilePositions())
            {
                DuelBoardGrid.grid[p.row, p.column] = currentBlock.Id;
                if (DuelBoardGrid.IsCellBomb(p.row + 1, p.column)) {
                    hitBomb = true;
                }
            }

            if (hitBomb) DuelBoardGrid.ClearGarbageLines(1);

            //bugcheck();

            linesCleared = DuelBoardGrid.ClearFullRows();

            clearedTetris = linesCleared == 4 ? true : false;

            Score += linesCleared * 10;

            int linesToSend = 0;

            switch (linesCleared)
            {
                case 0:
                    clearType.Visible = false;
                    break;
                case 1:
                case 2:
                    linesToSend = linesCleared;
                    clearType.Text = $"{linesToSend} line{(linesCleared == 2 ? "s" : "")}";
                    clearType.ForeColor = Color.HotPink;
                    clearType.Font = new Font(clearType.Font.FontFamily, 18, clearType.Font.Style);
                    break;
                case 3:
                    linesToSend = 4;
                    clearType.Text = "Triple!";
                    clearType.ForeColor = Color.DeepPink;
                    clearType.Font = new Font(clearType.Font.FontFamily, 22, clearType.Font.Style);
                    break;
                case 4:
                    linesToSend = 6;
                    clearType.Text = "Tetris!!!";
                    clearType.ForeColor = Color.Purple;
                    clearType.Font = new Font(clearType.Font.FontFamily, 26, clearType.Font.Style);
                    break;
                default:
                    throw new Exception("wth???");
            }

            if (linesCleared > 0)
            {
                VisibilityController.ShortVisible(clearType, linesCleared);
            }

            combo = (linesCleared > 0) ? combo + 1 : 0;

            switch (combo)
            {
                case 0:
                    comboType.Visible = false;
                    break;
                case 1:
                    if (clearedTetris && linesCleared == 4) linesToSend += 2; 
                    comboType.ForeColor = Color.Orange;
                    comboType.Font = new Font(clearType.Font.FontFamily, 18, clearType.Font.Style);
                    break;
                case 2:
                    comboType.ForeColor = Color.DarkOrange;
                    comboType.Font = new Font(clearType.Font.FontFamily, 18, clearType.Font.Style);
                    break;
                case 3:
                case 4:
                    linesToSend += 1;
                    comboType.ForeColor = Color.OrangeRed;
                    comboType.Font = new Font(clearType.Font.FontFamily, 20, clearType.Font.Style);
                    break;
                case 5:
                case 6:
                    linesToSend += 2;
                    comboType.ForeColor = Color.Red;
                    comboType.Font = new Font(clearType.Font.FontFamily, 22, clearType.Font.Style);
                    break;
                default:
                    linesToSend += 3;
                    comboType.ForeColor = Color.Firebrick;
                    comboType.Font = new Font(clearType.Font.FontFamily, 22, clearType.Font.Style);
                    break;
            }

            comboType.Text = $"x{combo}";

            if (combo > 0)
            {
                VisibilityController.ShortVisible(comboType, combo);
            }


            DuelBoardGrid.ClearGarbageLines(linesCleared);
            Opponent.ReceiveGarbageLines(linesToSend);

            DuelBoardGrid.AddGarbageLines(garbageLinesToAdd);
            garbageLinesToAdd = 0;

            if (IsGameOver()) GameOver = true;
            else { CurrentBlock = BlockQueue.RandomBlock(); canHold = true; }
        }

        public void ReceiveGarbageLines(int lines) { garbageLinesToAdd += lines; }
    }

    public static class VisibilityController
    {
        private static readonly ConcurrentDictionary<Label, CancellationTokenSource> _cancellationTokens = new ConcurrentDictionary<Label, CancellationTokenSource>();

        public static void ShortVisible(Label label, int length)
        {
            if (_cancellationTokens.TryGetValue(label, out var existingTokenSource))
            {
                existingTokenSource.Cancel();
                _cancellationTokens.TryRemove(label, out _);
            }

            var newTokenSource = new CancellationTokenSource();
            _cancellationTokens[label] = newTokenSource;

            Task.Run(async () =>
            {
                try
                {
                    label.Invoke(new Action(() => label.Visible = true));

                    await Task.Delay(2500 + length * 500, newTokenSource.Token);

                    label.Invoke(new Action(() => label.Visible = false));
                }
                catch (TaskCanceledException)
                {
                    // Task was cancelled, no action needed.
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
                finally
                {
                    _cancellationTokens.TryRemove(label, out _);
                }
            });
        }
    }

}
