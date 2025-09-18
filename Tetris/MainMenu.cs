using static RainbowText.RainbowText;

namespace Tetris    
{
    public partial class MainMenu : UserControl
    {
        Tetris parentForm;
        public MainMenu()
        {
            InitializeComponent();
            MakeRainbow(tetrisTitle, 25);
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            parentForm = FindForm() as Tetris;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            parentForm.Close();
        }

        private void arcade_Click(object sender, EventArgs e)
        {
            Dispose();
            parentForm.ShowArcadeUI();
        }

        private void duoBattle_Click(object sender, EventArgs e)
        {
            Dispose();
            parentForm.ShowDuoUI();
        }
    }
}