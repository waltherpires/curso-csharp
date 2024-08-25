using System;

namespace PropriedadesDateTimeOperacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000, 8, 15, 13, 45, 58);

            DateTime d2 = d1.AddHours(2);

            DateTime d3 = d1.AddMinutes(3);

            DateTime d4 = new DateTime(2000, 10, 15);
            DateTime d5 = new DateTime(2000, 10, 18);

            // Diferenca entre duas datas
            TimeSpan t = d5.Subtract(d4);
            Console.WriteLine(t);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            //x.Add(TimeSpan)
            //x.AddDays(double)
            //x.AddHours(double)
            //x.AddMilliseconds(double)
            //x.AddMinutes(double)
            //x.AddMonths(int)
            //x.AddSeconds(double)
            //x.AddTicks(long)
            //x.AddYears(int)
            
            //DateTime y = x.Subtract(timeSpan)
            //TimeSpan t = x.Subtract(dateTime)
        }
    }
}
