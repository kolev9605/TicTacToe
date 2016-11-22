namespace TicTacToe.Game
{
    using System;
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

        public override bool Equals(object obj)
        {
            Cell other = obj as Cell;

            if (other == null)
            {
                throw new NullReferenceException();
            }

            return this.Type == other.Type;
        }
    }
}
