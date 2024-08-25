using System;
using System.Globalization;

namespace ExercicioCotacaoDolar
{
    internal class ConversorDeMoeda
    {
        public static double CotacaoDolar;

        public static double ConverterParaDolar(double real)
        {
            return real * (CotacaoDolar * 1.06);
        }
    }
}
