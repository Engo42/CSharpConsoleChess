using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1Csharp
{
    class Empty : Piece
    {
        public Empty(Board Parent, int x_pos, int y_pos, int Color) : base(Parent, x_pos, y_pos, Color)
        {
            Type += ".";
        }
        public override bool IsLegalMove(int x2, int y2)
        {
            return false;
        }
    }
}
