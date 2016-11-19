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
            this.Hide();
            var mainForm = new MainForm();
            mainForm.Closed += (s, args) => this.Close();
            mainForm.Show();
        }
    }
}
