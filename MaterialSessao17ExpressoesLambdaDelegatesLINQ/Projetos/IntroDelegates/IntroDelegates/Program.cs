﻿using Course.Services;

namespace IntroDelegates
{
    delegate void BinaryNumericOperation(double n1, double n2);
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;
            op(a, b);
        }
    }
}
