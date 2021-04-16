using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace ConsoleApp1Csharp
{
    class Program
    {
        static void Main()
        {
            string[,] BoardConfig = new string[,]
            {
                {"bR", "bN", "bB", "bQ", "bK", "bB", "bN", "bR"},
                {"bP", "bP", "bP", "bP", "bP", "bP", "bP", "bP"},
                {" .", " .", " .", " .", " .", " .", " .", " ."},
                {" .", " .", " .", " .", " .", " .", " .", " ."},
                {" .", " .", " .", " .", " .", " .", " .", " ."},
                {" .", " .", " .", " .", " .", " .", " .", " ."},
                {"wP", "wP", "wP", "wP", "wP", "wP", "wP", "wP"},
                {"wR", "wN", "wB", "wQ", "wK", "wB", "wN", "wR"}
            };
            ChessGame NewGame = new ChessGame();
            NewGame.StartGame(BoardConfig);
            Console.ReadLine();
        }
    }
}
