using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1Csharp
{
    public class ChessGame
    {
        Board GameBoard;
        int MoveCnt;
        public void StartGame(string[,] BoardConfig)
        {
            GameBoard = new Board(BoardConfig);
            MoveCnt = 0;
            GameBoard.DrawBoard();
            string input;
            int PlayerWins = -1;
            while (PlayerWins == -1)
            {
                MoveCnt++;
                int SuccessfulMove = 0;
                while (SuccessfulMove == 0)
                {
                    if (MoveCnt % 2 == 0)
                        Console.Write("Ход черных >> ");
                    else
                        Console.Write("Ход белых  >> ");
                    input = Console.ReadLine();
                    int x1 = input[0] - 'a', y1 = input[1] - '1', x2 = input[2] - 'a', y2 = input[3] - '1';
                    if (GameBoard.MakeMove(x1, y1, x2, y2, -1 + 2 * (MoveCnt % 2)))
                    {
                        SuccessfulMove = 1;
                        if (GameBoard.IsGameOver())
                        {
                            PlayerWins = MoveCnt % 2;
                        }
                        GameBoard.DrawBoard();
                    }
                    else
                    {
                        Console.WriteLine("Неверный ход.");
                    }
                }
            }
            if (PlayerWins == 0)
            {
                Console.WriteLine("Победили чёрные!");
            }
            else
            {
                Console.WriteLine("Победили белые!");
            }
        }
    }
}
