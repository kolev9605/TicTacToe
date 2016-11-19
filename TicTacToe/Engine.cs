namespace TicTacToe.Game
{
    using TicTacToe.Game.Forms;

    public class Engine
    {
        private GameForm gameForm;
        private Board board;

        public Engine(GameForm gameForm)
        {
            this.gameForm = gameForm;
            this.board = new Board();
        }
    }
}
