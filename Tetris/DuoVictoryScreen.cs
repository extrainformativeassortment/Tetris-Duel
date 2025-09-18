namespace Tetris
{
    public partial class DuoVictoryScreen : UserControl
    {
        public DuoVictoryScreen(int Id)
        {
            InitializeComponent();
            winner.Text = $"Player {Id} won!";
        }

        private void restart_Click(object sender, EventArgs e)
        {
            Tetris parentForm = FindForm() as Tetris;
            parentForm.ShowDuoUI();
        }
    }
}
