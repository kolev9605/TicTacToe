namespace TicTacToe.Game.Forms
{
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        private int startTurn;

        public MainForm(int startTurn = -1)
        {
            this.InitializeComponent();
            this.startTurn = startTurn;
        }

        private void quitButton_Click(object sender, System.EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to quit?",
                                     "Confirm Exit",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void playButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            var gameForm = new GameForm(this.startTurn);
            gameForm.Closed += (s, args) => this.Close();
            gameForm.Show();
        }

        private void optionsButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            var optionsForm = new OptionsForm();
            optionsForm.Closed += (s, args) => this.Close();
            optionsForm.Show();
        }
    }
}
