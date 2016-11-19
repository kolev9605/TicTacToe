namespace TicTacToe.Game
{
    public class Board
    {
        private readonly Cell[,] board;

        public Board()
        {
            this.board = new Cell[3,3];
        }

        public bool HasWon()
        {
            return false;
        }

        public bool Place(int row, int col, CellType type)
        {
            if (this.board[row,col] == null || this.board[row,col].Type == CellType.Empty)
            {
                var cell = new Cell(type);
                this.board[row, col] = cell;
                return true;
            }

            return false;
        }
    }
}