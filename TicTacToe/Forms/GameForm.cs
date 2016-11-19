namespace TicTacToe.Game.Forms
{
    using System.Windows.Forms;

    public partial class GameForm : Form
    {
        private ImageLoader loader;
        private PictureBox picture;
        public GameForm()
        {
            this.loader = new ImageLoader(1,1,CellType.O);
            this.picture = this.loader.Picture;
            this.InitializeComponent();
        }


    }
}
