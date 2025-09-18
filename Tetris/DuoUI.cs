using Tetris.Duel;

namespace Tetris
{
    public partial class DuoUI : UserControl
    {
        DuelBoard board1 = new(1);
        DuelBoard board2 = new(2);

        public DuoUI()
        {
            InitializeComponent();
            board1.DuelBGS.Opponent = board2.DuelBGS;
            board2.DuelBGS.Opponent = board1.DuelBGS;
        }

        private void DuoUI_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Add(board1, 0, 0);
            board1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(board2, 1, 0);
            board2.Dock = DockStyle.Fill;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.W:
                case Keys.A:
                case Keys.S:
                case Keys.D:
                case Keys.Space:
                case Keys.Z:
                    board1.HandleKeyPress(keyData); 
                    return true;
                case Keys.Up:
                case Keys.Left:
                case Keys.Down:
                case Keys.Right:
                case Keys.NumPad0:
                case Keys.NumPad1:
                    board2.HandleKeyPress(keyData);
                    return true;

                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void DuoUI_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}
