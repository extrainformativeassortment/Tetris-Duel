using System.Windows.Forms;

namespace Tetris
{
    public partial class Tetris : Form
    {
        public Tetris()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            MainMenu mainMenu = new();
            Controls.Add(mainMenu);
            mainMenu.BringToFront();
            mainMenu.Dock = DockStyle.Fill;
        }

        public void ShowArcadeUI()
        {
            Controls.Clear();
            ArcadeUI arcadeUI = new();
            Controls.Add(arcadeUI);
            arcadeUI.Dock = DockStyle.Fill;
            arcadeUI.Focus();
        }

        public void ShowDuoUI()
        {
            Controls.Clear();
            DuoUI duoUI = new();
            Controls.Add(duoUI);
            duoUI.Dock = DockStyle.Fill;
            duoUI.Focus();
        }
    }
}