namespace TicTacToe.Game
{
    using System;
    using System.Runtime.CompilerServices;

    public class Board
    {
        public Cell[,] board;

        public Board()
        {
            this.board = new Cell[3, 3];
            for (int i = 0; i < this.board.GetLength(0); i++)
            {
                for (int j = 0; j < this.board.GetLength(1); j++)
                {
                    this.board[i, j] = new Cell();
                }
            }
        }

        public WinnerType Winner { get; private set; }

        public bool HasWon()
        {
            bool firstRowWin = this.board[0, 0].Equals(this.board[0, 1]) && this.board[0, 0].Equals(this.board[0, 2]) && !this.board[0, 0].Type.Equals(CellType.Empty);
            bool secondRowWin = this.board[1, 0].Equals(this.board[1, 1]) && this.board[1, 0].Equals(this.board[1, 2]) && !this.board[1, 0].Type.Equals(CellType.Empty);
            bool thirdRowWin = this.board[2, 0].Equals(this.board[2, 1]) && this.board[2, 0].Equals(this.board[2, 2]) && !this.board[2, 0].Type.Equals(CellType.Empty);
            ;
            bool firstColWin = this.board[0, 0].Equals(this.board[1, 0]) && this.board[0, 0].Equals(this.board[2, 0]) && !this.board[0, 0].Type.Equals(CellType.Empty);
            bool secondColWin = this.board[0, 1].Equals(this.board[1, 1]) && this.board[0, 1].Equals(this.board[2, 1]) && !this.board[0, 1].Type.Equals(CellType.Empty);
            bool thirdColWin = this.board[0, 2].Equals(this.board[1, 2]) && this.board[0, 2].Equals(this.board[2, 2]) && !this.board[0, 2].Type.Equals(CellType.Empty);
            ;
            bool firstDiagWin = this.board[0, 0].Equals(this.board[1, 1]) && this.board[0, 0].Equals(this.board[2, 2]) && !this.board[0, 0].Type.Equals(CellType.Empty);
            bool secondDiagWin = this.board[2, 0].Equals(this.board[1, 1]) && this.board[2, 0].Equals(this.board[0, 2]) && !this.board[2, 0].Type.Equals(CellType.Empty);

            if (firstRowWin)
            {
                this.Winner = WinnerType.FirstRow;
                return true;
            }
            else if (secondRowWin)
            {
                this.Winner = WinnerType.SecondRow;
                return true;
            }
            else if (thirdRowWin)
            {
                this.Winner = WinnerType.ThirdRow;
                return true;
            }
            else if (firstColWin)
            {
                this.Winner = WinnerType.FirstCol;
                return true;
            }
            else if (secondColWin)
            {
                this.Winner = WinnerType.SecondCol;
                return true;
            }
            else if (thirdColWin)
            {
                this.Winner = WinnerType.ThirdCol;
                return true;
            }
            else if (firstDiagWin)
            {
                this.Winner = WinnerType.FirstDiag;
                return true;
            }
            else if (secondDiagWin)
            {
                this.Winner = WinnerType.SecondDiag;
                return true;
            }

            return false;
        }

        public bool Place(int row, int col, CellType type)
        {
            if (this.board[row, col] == null || this.board[row, col].Type == CellType.Empty)
            {
                var cell = new Cell(type);
                this.board[row, col] = cell;
                return true;
            }

            return false;
        }

        public CellType GetWinner(int turn)
        {
            if (turn % 2 == 0)
            {
                return CellType.X
                    ;
            }
            else
            {
                return CellType.O;
                ;
            }
        }
    }
}