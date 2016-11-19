namespace TicTacToe.Game
{
    public class Cell
    {
        public Cell(CellType type = CellType.Empty)
        {
            this.Type = type;
        }

        public CellType Type { get; private set; }

        public bool IsFree()
        {
            return this.Type == CellType.Empty;
        }
    }
}
