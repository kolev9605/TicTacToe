namespace TicTacToe.Game.Forms
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    public partial class GameForm : Form
    {
        private Board board;
        private int turn;
        private int initialTurn;

        public GameForm(int turn = -1)
        {
            this.board = new Board();
            this.turn = turn;
            this.initialTurn = turn;
            this.InitializeComponent();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            this.BeginNewGame();
        }

        private void BeginNewGame()
        {
            foreach (var control in this.Controls.Cast<Control>().ToArray())
            {
                control.Dispose();
            }

            this.board = new Board();
            this.turn = this.initialTurn;
            this.InitializeComponent();
        }

        private CellType GetCurrentType()
        {
            if (this.turn % 2 == 0)
            {
                return CellType.X;
            }
            else
            {
                return CellType.O;
            }
        }

        private void PlaceCurrentTypeImage(PictureBox pictureBox)
        {
            this.turn++;
            if (this.turn % 2 == 0)
            {
                pictureBox.Image = Properties.Resources.x;
            }
            else
            {
                pictureBox.Image = Properties.Resources.o;
            }
        }
        private void CheckForWinner()
        {
            if (this.board.HasWon())
            {
                var winningPlace = this.board.Winner;
                var winner = this.board.GetWinner(this.turn);

                MessageBox.Show(winner.ToString());
                this.BeginNewGame();
            }
        }

        private void PlaceOnBoard(int row, int col)
        {
            var type = this.GetCurrentType();
            this.board.Place(row, col, type);
        }

        private void firstCellPictureBox_Click(object sender, EventArgs e)
        {
            if (this.firstCellPictureBox.Image == null)
            {
                this.PlaceCurrentTypeImage(this.firstCellPictureBox);
                this.PlaceOnBoard(0, 0);
                this.CheckForWinner();
            }
        }

        private void secondCellPictureBox_Click(object sender, EventArgs e)
        {
            if (this.secondCellPictureBox.Image == null)
            {
                this.PlaceCurrentTypeImage(this.secondCellPictureBox);
                this.PlaceOnBoard(0, 1);
                this.CheckForWinner();
            }
        }

        private void thirdCellPictureBox_Click(object sender, EventArgs e)
        {
            if (this.thirdCellPictureBox.Image == null)
            {
                this.PlaceCurrentTypeImage(this.thirdCellPictureBox);
                this.PlaceOnBoard(0, 2);
                this.CheckForWinner();
            }
        }

        private void fourthCellPictureBox_Click(object sender, EventArgs e)
        {
            if (this.fourthCellPictureBox.Image == null)
            {
                this.PlaceCurrentTypeImage(this.fourthCellPictureBox);
                this.PlaceOnBoard(1, 0);
                this.CheckForWinner();
            }
        }

        private void fifthCellPictureBox_Click(object sender, EventArgs e)
        {
            if (this.fifthCellPictureBox.Image == null)
            {
                this.PlaceCurrentTypeImage(this.fifthCellPictureBox);
                this.PlaceOnBoard(1, 1);
                this.CheckForWinner();
            }
        }

        private void sixthCellPictureBox_Click(object sender, EventArgs e)
        {
            if (this.sixthCellPictureBox.Image == null)
            {
                this.PlaceCurrentTypeImage(this.sixthCellPictureBox);
                this.PlaceOnBoard(1, 2);
                this.CheckForWinner();
            }
        }

        private void seventhCellPictureBox_Click(object sender, EventArgs e)
        {
            if (this.seventhCellPictureBox.Image == null)
            {
                this.PlaceCurrentTypeImage(this.seventhCellPictureBox);
                this.PlaceOnBoard(2, 0);
                this.CheckForWinner();
            }
        }

        private void eighthCellPictureBox_Click(object sender, EventArgs e)
        {
            if (this.eighthCellPictureBox.Image == null)
            {
                this.PlaceCurrentTypeImage(this.eighthCellPictureBox);
                this.PlaceOnBoard(2, 1);
                this.CheckForWinner();
            }
        }

        private void ninthCellPictureBox_Click(object sender, EventArgs e)
        {
            if (this.ninthCellPictureBox.Image == null)
            {
                this.PlaceCurrentTypeImage(this.ninthCellPictureBox);
                this.PlaceOnBoard(2, 2);
                this.CheckForWinner();
            }
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