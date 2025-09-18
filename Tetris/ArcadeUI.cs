using System.Diagnostics;
using Tetris.BoardGroup;

namespace Tetris
{
    public partial class ArcadeUI : UserControl
    {
        Board board = new();
        public ArcadeUI()
        {
            InitializeComponent();
        }

        private void ArcadeUI_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Add(board, 1, 0);
            board.Dock = DockStyle.Fill;
        }
        // Inside your Board class
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            board.HandleKeyPress(keyData);
            return true;
        }
    }
}
