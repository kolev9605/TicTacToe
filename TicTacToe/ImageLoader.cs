namespace TicTacToe.Game
{
    using System;
    using System.Windows.Forms;

    public class ImageLoader
    {
        private PictureBox picture;
        private CoordinateTransformer transformer;

        public ImageLoader(int row, int col, CellType type)
        {
            this.transformer = new CoordinateTransformer();
            this.picture = this.LoadImage(row, col, type);
        }

        public PictureBox Picture => this.picture;

        private PictureBox LoadImage(int row, int col, CellType type)
        {
            PictureBox image = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)(image)).BeginInit();

            if (type == CellType.O)
            {
                image.Image = Properties.Resources.o;
            }
            else if (type == CellType.X)
            {
                image.Image = Properties.Resources.x;
            }
            else
            {
                throw new ArgumentException("Invalid Cell type.");
            }

            var coordinates = this.transformer.GetCoordinates(row, col);

            image.Location = new System.Drawing.Point(coordinates.Item1, coordinates.Item2);
            image.Name = $"{type.ToString().ToLower()}Picture{row}{col}";
            image.Size = new System.Drawing.Size(100, 101);
            image.TabIndex = 1;
            image.TabStop = false;

            return image;
        }
    }
}