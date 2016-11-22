namespace TicTacToe.Game.Forms
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    public partial class GameForm : Form
    {
        private readonly CoordinateTransformer transformer;
        private Board board;
        private int turn;

        public GameForm()
        {
            this.transformer = new CoordinateTransformer();
            this.board = new Board();
            this.turn = -1;
            this.InitializeComponent();
            this.boardImage.MouseClick += this.myForm_MouseClick;
        }

        private void myForm_MouseClick(object sender, MouseEventArgs e)
        {
            int clickX = e.X;
            int clickY = e.Y;
            this.turn++;
            var cell = this.GetCellToPlace(clickX, clickY);
            if (cell != null)
            {
                if (this.turn % 2 == 0)
                {
                    this.PlaceImage(cell.Item1, cell.Item2, CellType.X);
                    this.board.Place(cell.Item1, cell.Item2, CellType.X);

                }
                else
                {
                    this.PlaceImage(cell.Item1, cell.Item2, CellType.O);
                    this.board.Place(cell.Item1, cell.Item2, CellType.O);
                }
            }


            if (this.board.HasWon())
            {
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < this.board.board.GetLength(0); i++)
                {
                    for (int j = 0; j < this.board.board.GetLength(1); j++)
                    {
                        builder.Append(this.board.board[i, j].Type + " ");
                    }

                    builder.AppendLine();
                }

                var winner = this.board.GetWinner(turn);
                MessageBox.Show($"Winner is {winner} in {this.board.Winner}{Environment.NewLine}{builder.ToString()}");
            }
        }

        private Tuple<int, int> GetCellToPlace(int x, int y)
        {
            bool isFirstCell = x >= Constants.BoardBoundsFirstCellX1 && x <= Constants.BoardBoundsFirstCellX2 &&
                    y >= Constants.BoardBoundsFirstCellY1 && y <= Constants.BoardBoundsFirstCellY2;

            bool isSecondCell = x >= Constants.BoardBoundsSecondCellX1 && x <= Constants.BoardBoundsSecondCellX2 &&
                   y >= Constants.BoardBoundsSecondCellY1 && y <= Constants.BoardBoundsSecondCellY2;

            bool isThirdCell = x >= Constants.BoardBoundsThirdCellX1 && x <= Constants.BoardBoundsThirdCellX2 &&
                   y >= Constants.BoardBoundsThirdCellY1 && y <= Constants.BoardBoundsThirdCellY2;

            bool isFourthCell = x >= Constants.BoardBoundsFourthCellX1 && x <= Constants.BoardBoundsFourthCellX2 &&
                   y >= Constants.BoardBoundsFourthCellY1 && y <= Constants.BoardBoundsFourthCellY2;

            bool isFifthCell = x >= Constants.BoardBoundsFifthCellX1 && x <= Constants.BoardBoundsFifthCellX2 &&
                   y >= Constants.BoardBoundsFifthCellY1 && y <= Constants.BoardBoundsFifthCellY2;

            bool isSixthCell = x >= Constants.BoardBoundsSixthCellX1 && x <= Constants.BoardBoundsSixthCellX2 &&
                   y >= Constants.BoardBoundsSixthCellY1 && y <= Constants.BoardBoundsSixthCellY2;

            bool isSeventhCell = x >= Constants.BoardBoundsSeventhCellX1 && x <= Constants.BoardBoundsSeventhCellX2 &&
                   y >= Constants.BoardBoundsSeventhCellY1 && y <= Constants.BoardBoundsSeventhCellY2;

            bool isEightCell = x >= Constants.BoardBoundsEightCellX1 && x <= Constants.BoardBoundsEightCellX2 &&
                   y >= Constants.BoardBoundsEightCellY1 && y <= Constants.BoardBoundsEightCellY2;

            bool isNinthCell = x >= Constants.BoardBoundsNinghtCellX1 && x <= Constants.BoardBoundsNinghtCellX2 &&
                   y >= Constants.BoardBoundsNinghtCellY1 && y <= Constants.BoardBoundsNinghtCellY2;

            if (isFirstCell)
            {
                return new Tuple<int, int>(0, 0);
            }
            else if (isSecondCell)
            {
                return new Tuple<int, int>(0, 1);
            }
            else if (isThirdCell)
            {
                return new Tuple<int, int>(0, 2);
            }
            else if (isFourthCell)
            {
                return new Tuple<int, int>(1, 0);
            }
            else if (isFifthCell)
            {
                return new Tuple<int, int>(1, 1);
            }
            else if (isSixthCell)
            {
                return new Tuple<int, int>(1, 2);
            }
            else if (isSeventhCell)
            {
                return new Tuple<int, int>(2, 0);
            }
            else if (isEightCell)
            {
                return new Tuple<int, int>(2, 1);
            }
            else if (isNinthCell)
            {
                return new Tuple<int, int>(2, 2);
            }
            else
            {
                return null;
            }
        }

        private void PlaceImage(int row, int col, CellType type)
        {
            var image = new PictureBox();

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
            this.Controls.Add(image);
            image.BringToFront();
            ((System.ComponentModel.ISupportInitialize)(image)).EndInit();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            foreach (var control in Controls.Cast<Control>().ToArray())
            {
                control.Dispose();
            }
            
            this.board = new Board();
            this.turn = -1;
            this.InitializeComponent();
            this.boardImage.MouseClick += this.myForm_MouseClick;
        }
    }
}