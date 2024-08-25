using System;
using System.Data;
using System.Globalization;

namespace ModificadoresRefEOut
{
    internal class Calculator
    {
        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        public static void TripleOut(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
