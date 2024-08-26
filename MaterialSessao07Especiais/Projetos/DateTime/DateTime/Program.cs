using System;
using System.Globalization;

namespace Tempo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Varios Construtores
            DateTime d1 = new DateTime(1999, 06, 20);
            DateTime d2 = new DateTime(1999, 06, 20, 20, 45, 3);
            DateTime d3 = new DateTime(1999, 06, 20, 20, 45, 3, 500);

            // Horario UTC - 3 horas a frente do Brasil
            DateTime d4 = DateTime.UtcNow;

            // Momento exato da maquina
            DateTime agora = DateTime.Now;

            // Dia da maquina com horario 00:00:00
            DateTime hoje = DateTime.Today;

            // Converter String em DateTime
            DateTime d5 = DateTime.Parse("2000-08-15");
            DateTime d6 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d7 = DateTime.Parse("15/08/2000");
            DateTime d8 = DateTime.Parse("15/08/2000 13:05:58");

            // Criar o meu Padrao
            DateTime d9 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d10 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);


            Console.WriteLine("CONSTRUTORES: ");
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            Console.WriteLine();
            Console.WriteLine("VARIADOS:");
            Console.WriteLine(agora);
            Console.WriteLine(hoje);
            Console.WriteLine(d4);

            Console.WriteLine();
            Console.WriteLine("CONVERTIDOS:");
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);

        }
    }
}
