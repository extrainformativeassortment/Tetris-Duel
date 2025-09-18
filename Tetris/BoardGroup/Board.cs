using Tetris.Blocks;

namespace Tetris.BoardGroup
{
    internal partial class Board : UserControl
    {
        public virtual BoardState BGS { get; set; } = new();
        protected virtual int[,] Grid => BGS.BoardGrid.grid;
        protected virtual BoardGrid BG => BGS.BoardGrid;
        protected virtual Block currentBlock => BGS.CurrentBlock;
        protected virtual Block nextBlock => BGS.BlockQueue.NextBlock;
        protected virtual Block holdBlock => BGS.HoldBlock;
        
        protected int delay = 500, factor = 5, speedup = 0;

        Rectangle cellRect; 
        
        private Dictionary<Keys, Action> keyActions = new();

        public Board()
        {
            InitializeComponent();
            DoubleBuffered = true;
            AssignArcadeKeys();
        }

        private void AssignArcadeKeys()
        {
            keyActions[Keys.Up] = () => BGS.RotateCW();
            keyActions[Keys.Left] = () => BGS.MoveHorizontal(-1);
            keyActions[Keys.Down] = () => BGS.MoveDown();
            keyActions[Keys.Right] = () => BGS.MoveHorizontal(1);
            keyActions[Keys.Space] = () => { BGS.HardDrop(); nextPanel.Invalidate(); };
            keyActions[Keys.Z] = () => { BGS.SwitchHold(); holdPanel.Invalidate(); };
        }
        protected void TetrisBoard_Load(object sender, EventArgs e)
        {
            Start();
        }

        public void Start()
        {
            boardPanel.Invalidate();
            GameLoop();
        }

        protected async Task GameLoop()
        {
            while (!BGS.GameOver)
            {
                await Task.Delay(Math.Max(200, delay - (BGS.Score * factor / 10)));
                delay -= speedup;
                BGS.MoveDown();
                boardPanel.Invalidate();
                nextPanel.Invalidate();
                scoreLabel.Text = $"Score: {BGS.Score}";
            }
            GameOver();
        }

        protected virtual void GameOver()
        {
            Form form = FindForm();
            form.Controls.Clear();
            GameOverMenu gameOverMenu = new(BGS.Score);
            form.Controls.Add(gameOverMenu);
            gameOverMenu.Dock = DockStyle.Fill;
            gameOverMenu.BringToFront();
        }

        public void HandleKeyPress(Keys keyData)
        {
            if (BGS.GameOver) return;

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
        protected static Color GetRandomColor()
        {
            Random random = new Random();
            int red = random.Next(256);
            int green = random.Next(256);
            int blue = random.Next(256);
            return Color.FromArgb(red, green, blue);
        }

        protected static Color GetColor(int Id)
        {
            return Id switch
            {
                1 => Color.PaleVioletRed,
                2 => Color.Aquamarine,
                3 => Color.PaleGreen,
                4 => Color.Indigo,
                5 => Color.HotPink,
                6 => Color.Yellow,
                7 => Color.Chocolate,
                -1 => Color.DarkGray,
                -2 => GetRandomColor(),
                _ => Color.Black,
            };
        }
        protected void boardPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int id = currentBlock.Id;
            Color color = GetColor(id);
            int side = boardPanel.Width / Grid.GetLength(1);

            Permanents_Paint(g, side, id);
            CurrentBlock_Paint(g, side, color);
            GhostBlock_Paint(g, side, id);
        }
        protected void Permanents_Paint(Graphics g, int side, int id)
        {
            for (int row = 2; row < BG.rows; row++)
            {
                for (int col = 0; col < BG.columns; col++)
                {
                    id = Grid[row, col];

                    cellRect = new(col * side, (row - 2) * side, side, side);
                    g.FillRectangle(new SolidBrush(GetColor(id)), cellRect);
                    g.DrawRectangle(Pens.LightGray, cellRect);
                }
            }
        }

        protected void CurrentBlock_Paint(Graphics g, int side, Color color)
        {
            foreach (Position p in currentBlock.TilePositions())
            {
                if (p.row < 2) continue;

                cellRect = new(p.column * side, (p.row - 2) * side, side, side);
                g.FillRectangle(new SolidBrush(color), cellRect);
                g.DrawRectangle(Pens.LightGray, cellRect);
            }
        }

        protected void GhostBlock_Paint(Graphics g, int side, int id)
        {
            Color shadowColor = Color.FromArgb(64, GetColor(id));
            int dropDistance = BGS.BlockDropDistance();

            foreach (Position p in currentBlock.TilePositions())
            {
                cellRect = new(p.column * side, (p.row - 2 + dropDistance) * side, side, side);
                g.FillRectangle(new SolidBrush(shadowColor), cellRect);
                g.DrawRectangle(Pens.LightGray, cellRect);
            }
        }

        protected void nextPanel_Paint(object sender, PaintEventArgs e)
        {
            if (nextBlock is null) return;

            Graphics g = e.Graphics;

            Color blockColor = GetColor(nextBlock.Id);
            int side = nextPanel.Height / 4;

            g.Clear(Color.Black);

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    foreach (Position p in nextBlock.TilePositionsNoOffset())
                    {
                        cellRect = new(p.column * side, p.row * side, side, side);
                        g.FillRectangle(new SolidBrush(blockColor), cellRect);
                        g.DrawRectangle(Pens.LightGray, cellRect);
                    }
                }
            }
        }

        protected void holdPanel_Paint(object sender, PaintEventArgs e)
        {
            if (holdBlock is null) return;

            Graphics g = e.Graphics;

            Color blockColor = GetColor(holdBlock.Id);
            int side = holdPanel.Height / 4;

            g.Clear(Color.Black);

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    foreach (Position p in holdBlock.TilePositionsNoOffset())
                    {
                        cellRect = new(p.column * side, p.row * side, side, side);
                        g.FillRectangle(new SolidBrush(blockColor), cellRect);
                        g.DrawRectangle(Pens.LightGray, cellRect);
                    }
                }
            }
        }
    }
}
