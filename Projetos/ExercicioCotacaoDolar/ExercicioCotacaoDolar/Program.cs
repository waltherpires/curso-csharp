using System.Linq.Expressions;
using System.Globalization;

namespace ExercicioCotacaoDolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual e a cotacao do dolar? ");
            ConversorDeMoeda.CotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares voce vai comprar? ");
            double real = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor a ser pago: " + ConversorDeMoeda.ConverterParaDolar(real).ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
