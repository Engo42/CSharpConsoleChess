using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1Csharp
{
    public abstract class Piece
    {
        protected Piece[,] Grid;
        public int x, y, c;
        public String Type;
        protected Piece(Board Parent, int x_pos, int y_pos, int Color)
        {
            Grid = Parent.Grid;
            x = x_pos;
            y = y_pos;
            c = Color;
            if (c == -1)
                Type = "b";
            else if (c == 1)
                Type = "w";
            else
                Type = " ";
        }
        public abstract bool IsLegalMove(int x2, int y2);
        protected bool IsWayClear(int x2, int y2)
        {
            int x_move = Math.Abs(x2 - x), y_move = Math.Abs(y2 - y), x_dir = 0, y_dir = 0;
            if (y_move != 0) y_dir = (y2 - y) / y_move;
            if (x_move != 0) x_dir = (x2 - x) / x_move;
            for (int i = 1; i < Math.Max(x_move, y_move); i++)
            {
                if (Grid[x + i * x_dir, y + i * y_dir].Type != " .")
                {
                    return false;
                }
            }
            if (Grid[x2, y2].Type != " ." && Grid[x2, y2].c == c)
            {
                return false;
            }
            return true;
        }
    }
}
