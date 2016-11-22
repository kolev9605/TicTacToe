namespace TicTacToe.Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CoordinateTransformer
    {
        private IDictionary<int, int> rowCoordinates;
        private IDictionary<int, int> colCoordinates;

        public CoordinateTransformer()
        {
            this.rowCoordinates = new Dictionary<int, int>();
            this.colCoordinates = new Dictionary<int, int>();

            this.InitDictionareis();
        }

        private void InitDictionareis()
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

        public Tuple<int, int> GetDimentions(int coordX, int coordY)
        {
            int x = this.colCoordinates.FirstOrDefault(p => p.Value == coordX).Key;
            int y = this.colCoordinates.FirstOrDefault(p => p.Value == coordY).Key;

            return new Tuple<int,int>(x,y);
        }
    }
}