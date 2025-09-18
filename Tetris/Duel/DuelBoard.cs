using Tetris.Blocks;
using Tetris.BoardGroup;

namespace Tetris.Duel
{
    internal partial class DuelBoard : Board
    {
        public int Id { get; }
        public override BoardState BGS { get; set; }
        protected override int[,] Grid => BGS.BoardGrid.grid;
        protected override BoardGrid BG => DuelBGS.DuelBoardGrid;
        protected override Block currentBlock => BGS.CurrentBlock;
        protected override Block nextBlock => BGS.BlockQueue.NextBlock;
        protected override Block holdBlock => BGS.HoldBlock;
        public DuelBoardState DuelBGS => (DuelBoardState)BGS;

        private Dictionary<Keys, Action> keyActions = new();

        public DuelBoard(int Id)
        {
            InitializeComponent();
            this.Id = Id;
            this.BGS = new DuelBoardState(Id, this.comboType, this.clearType);

            switch (Id)
            {
                case 1:
                    keyActions[Keys.W] = () => DuelBGS.RotateCW();
                    keyActions[Keys.A] = () => DuelBGS.MoveHorizontal(-1);
                    keyActions[Keys.S] = () => DuelBGS.MoveDown();
                    keyActions[Keys.D] = () => DuelBGS.MoveHorizontal(1);
                    keyActions[Keys.Space] = () => { DuelBGS.HardDrop(); nextPanel.Invalidate(); };
                    keyActions[Keys.Z] = () => { DuelBGS.SwitchHold(); holdPanel.Invalidate(); };
                    break;
                case 2:
                    keyActions[Keys.Up] = () => DuelBGS.RotateCW();
                    keyActions[Keys.Left] = () => DuelBGS.MoveHorizontal(-1);
                    keyActions[Keys.Down] = () => DuelBGS.MoveDown();
                    keyActions[Keys.Right] = () => DuelBGS.MoveHorizontal(1);
                    keyActions[Keys.NumPad0] = () => { DuelBGS.HardDrop(); nextPanel.Invalidate(); };
                    keyActions[Keys.NumPad1] = () => { DuelBGS.SwitchHold(); holdPanel.Invalidate(); };
                    break;
            }

            if (Id == 2) holdLabel.Text = "Hold (num1)"; 
            //if (Id == 1) delay = 1500;
            factor = 2;
        }
        public void HandleKeyPress(Keys keyData)
        {
            if (DuelBGS.GameOver)
            {
                return;
            }

            if (keyActions.TryGetValue(keyData, out Action action))
            {
                action();
                boardPanel.Invalidate();
                if (action.Method.Name.Contains("HardDrop") || action.Method.Name.Contains("SwitchHold"))
                {
                    nextPanel.Invalidate();
                    holdPanel.Invalidate();
                }
            }
        }

        protected override void GameOver()
        {
            Form form = FindForm();
            form.Controls.Clear();
            DuoVictoryScreen duoVictoryScreen = new(Id % 2 + 1);
            form.Controls.Add(duoVictoryScreen);
            duoVictoryScreen.Dock = DockStyle.Fill;
            duoVictoryScreen.BringToFront();
        }
    }
}