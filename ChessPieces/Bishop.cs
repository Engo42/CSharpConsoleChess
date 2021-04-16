using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1Csharp
{
    class Bishop : Piece
    {
        public Bishop(Board Parent, int x_pos, int y_pos, int Color) : base(Parent, x_pos, y_pos, Color)
        {
            Type += "B";
        }
        public override bool IsLegalMove(int x2, int y2)
        {
            int x_move = Math.Abs(x2 - x), y_move = Math.Abs(y2 - y);
            if (x_move != y_move)
            {
                return false;
            }
            return IsWayClear(x2, y2);
        }
    }
}
