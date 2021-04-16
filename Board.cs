using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1Csharp
{
    public class Board
    {
        public Piece[,] Grid;
        public Board(string[,] BoardConfig)
        {
            Grid = new Piece[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    int Color;
                    switch (BoardConfig[7 - j, i][0])
                    {
                        case 'w':
                            Color = 1;
                            break;
                        case 'b':
                            Color = -1;
                            break;
                        default:
                            Color = 0;
                            break;
                    }
                    switch (BoardConfig[7 - j, i][1])
                    {
                        case 'P':
                            Grid[i, j] = new Pawn(this, i, j, Color);
                            break;
                        case 'R':
                            Grid[i, j] = new Rook(this, i, j, Color);
                            break;
                        case 'N':
                            Grid[i, j] = new Knight(this, i, j, Color);
                            break;
                        case 'B':
                            Grid[i, j] = new Bishop(this, i, j, Color);
                            break;
                        case 'Q':
                            Grid[i, j] = new Queen(this, i, j, Color);
                            break;
                        case 'K':
                            Grid[i, j] = new King(this, i, j, Color);
                            break;
                        default:
                            Grid[i, j] = new Empty(this, i, j, Color);
                            break;
                    }
                }
            }
        }
        public bool MakeMove(int x1, int y1, int x2, int y2, int Color)
        {
            if (Grid[x1, y1].IsLegalMove(x2, y2) && Grid[x1, y1].c == Color)
            {
                Grid[x2, y2] = Grid[x1, y1];
                Grid[x2, y2].x = x2;
                Grid[x2, y2].y = y2;
                Grid[x1, y1] = new Empty(this, x1, y1, 0);
                return true;
            }
            return false;
        }
        public bool IsGameOver()
        {
            int KingCount = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (Grid[i, j].Type[1] == 'K')
                    {
                        KingCount++;
                    }
                }
            }
            if (KingCount < 2)
                return true;
            else
                return false;
        }
        public void DrawBoard()
        {
            Console.Write(" ");
            for (int i = 0; i < 8; i++)
            {
                Console.Write("  " + Convert.ToChar('a' + i));
            }
            for (int i = 7; i >= 0; i--)
            {
                Console.Write("\n");
                Console.Write(i + 1);
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(" " + Grid[j, i].Type);
                }
            }
            Console.Write("\n");
        }
    }
}
