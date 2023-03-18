using ChessEngine;
using ChessPlayerDLL;
using System;

namespace ChessPlayers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var engine = new ChessEngine.ChessEngine();
            var path = @"C:\Users\Camilla\source\repos\ChessPlayers\ChessPlayers\bin\Debug\net6.0\FirstMovePlayer.dll";
            var path2 = @"C:\Users\Camilla\source\repos\ChessPlayers\RandomMovePlayer\bin\Debug\net6.0\RandomMovePlayer.dll";
            engine.StartBotGame(path, path2, DrawBoard);
        }

        public static void DrawBoard(ChessBoard board)
        {
            Console.Clear();
            for (var y = 7; y >= 0; y--)
            {
                for (var x = 0; x < 8; x++)
                {
                    var piece = board.Board[x, y];
                    Console.Write(piece.FenRepresentation + " ");
                }

                Console.WriteLine();
            }
        }
    }
}