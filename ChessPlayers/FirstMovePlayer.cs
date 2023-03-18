using ChessPlayerDLL;

namespace ChessPlayers
{
    public class FirstMovePlayer : IChessPlayer
    {
        private ChessBoard board;

        private bool isWhite;

        public bool IsChessPlayer => true;

        public IEnumerable<(int, string)> GetDifficulties()
        {
            return new[] { (1, "Default") };
        }

        public Move GetMove()
        {
            var move = this.board.GetMoves(this.isWhite ? Color.White : Color.Black).First();
            this.board.DoMove(move);
            return move;
        }

        public void Initialize(bool playAsWhite, int difficulty, int timePerMove)
        {
            this.isWhite = playAsWhite;
            this.board = new ChessBoard();
            this.board.SetupBoard();
        }

        public void MoveMade(Move move)
        {
            this.board.DoMove(move);
        }
    }
}