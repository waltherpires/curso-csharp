using System;

namespace AulaStruct
{
    struct Point
    {
        public int X;
        public int Y;

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }
    }
}
