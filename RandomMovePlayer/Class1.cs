using ChessPlayerDLL;

namespace RandomMovePlayer
{
    public class RandomMovePlayer : IChessPlayer
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
            var list = this.board.GetMoves(this.isWhite ? Color.White : Color.Black).ToList();
            var move = list[new Random().Next(0, list.Count)];
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