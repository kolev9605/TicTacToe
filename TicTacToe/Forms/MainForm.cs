namespace TicTacToe.Game.Forms
{
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.InitializeComponent();
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
            var gameForm = new GameForm();
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
