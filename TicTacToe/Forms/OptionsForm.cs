namespace TicTacToe.Game.Forms
{
    using System.Windows.Forms;

    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            this.InitializeComponent();
        }

        private void backButton_Click(object sender, System.EventArgs e)
        {
            int startTurn;
            if (this.radioButton1.Checked)
            {
                startTurn = -1;
            }
            else
            {
                startTurn = 0;
            }

            this.Hide();
            var mainForm = new MainForm(startTurn);
            mainForm.Closed += (s, args) => this.Close();
            mainForm.Show();
        }
    }
}
