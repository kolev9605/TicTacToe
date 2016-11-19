namespace TicTacToe.Game
{
    using System;
    using System.Collections.Generic;

    public class CoordinateTransformer
    {
        private IDictionary<int, int> rowCoordinates;
        private IDictionary<int, int> colCoordinates;

        public CoordinateTransformer()
        {
            this.rowCoordinates = new Dictionary<int, int>();
            this.colCoordinates = new Dictionary<int, int>();
            this.InitDictionary();
        }

        private void InitDictionary()
        {
            this.colCoordinates[0] = 190;
            this.colCoordinates[1] = 336;
            this.colCoordinates[2] = 486;

            this.rowCoordinates[0] = 127;
            this.rowCoordinates[1] = 274;
            this.rowCoordinates[2] = 430;
        }

        public Tuple<int, int> GetCoordinates(int row, int col)
        {
            return new Tuple<int, int>(this.colCoordinates[col], this.rowCoordinates[row]);
        }
    }
}
