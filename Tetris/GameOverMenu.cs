namespace Tetris.BoardGroup
{
    public partial class GameOverMenu : UserControl
    {
        public GameOverMenu(int score)
        {
            InitializeComponent(); 
            finalScore.Text = $"Score: {score}";
        }

        private void restart_Click(object sender, EventArgs e)
        {
            Tetris parentForm = FindForm() as Tetris;
            parentForm.ShowArcadeUI();
        }
    }
}
