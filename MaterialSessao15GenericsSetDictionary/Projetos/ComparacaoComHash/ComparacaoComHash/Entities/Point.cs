using System;
using System.Collections.Generic;

namespace ComparacaoComHash.Entities
{
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y) : this()
        {
            X = x;
            Y = y;
        }
    }
}
