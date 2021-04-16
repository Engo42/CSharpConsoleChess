using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1Csharp
{
    class Rook : Piece
    {
        public Rook(Board Parent, int x_pos, int y_pos, int Color) : base(Parent, x_pos, y_pos, Color)
        {
            Type += "R";
        }
        public override bool IsLegalMove(int x2, int y2)
        {
            int x_move = Math.Abs(x2 - x), y_move = Math.Abs(y2 - y);
            if (x_move != 0 && y_move != 0)
            {
                return false;
            }
            return IsWayClear(x2, y2);
        }
    }
}
