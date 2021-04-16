using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1Csharp
{
    class Knight : Piece
    {
        public Knight(Board Parent, int x_pos, int y_pos, int Color) : base(Parent, x_pos, y_pos, Color)
        {
            Type += "N";
        }
        public override bool IsLegalMove(int x2, int y2)
        {
            int x_move = Math.Abs(x2 - x), y_move = Math.Abs(y2 - y);
            if ((x_move != 1 || y_move != 2) && (x_move != 2 || y_move != 1))
            {
                return false;
            }
            if (Grid[x2, y2].Type != " ." && Grid[x2, y2].c == c)
            {
                return false;
            }
            return true;
        }
    }
}
