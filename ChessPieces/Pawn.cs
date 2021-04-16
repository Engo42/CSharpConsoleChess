using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1Csharp
{
    class Pawn : Piece
    {
        public Pawn(Board Parent, int x_pos, int y_pos, int Color) : base(Parent, x_pos, y_pos, Color)
        {
            Type += "P";
        }
        public override bool IsLegalMove(int x2, int y2)
        {
            int x_move = x2 - x, y_move = y2 - y;
            if (Grid[x2, y2].Type == " ." && (x_move != 0 || y_move != c && (y_move != 2 * c || y != 3.5 - 2.5 * c)))
            {
                return false;
            }
            if (Grid[x2, y2].Type != " ." && (Grid[x2, y2].c == c || Math.Abs(x_move) != 1 || y_move != c))
            {
                return false;
            }
            return true;
        }
    }
}
