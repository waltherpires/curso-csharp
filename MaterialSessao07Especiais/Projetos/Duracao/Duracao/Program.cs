using System;

namespace Duracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Converte dias para o formato do TimeSpan (1.12:00:00)
            TimeSpan t1 = TimeSpan.FromDays(1.5);

            //Converte horas para o formato do TimeSpan (01:30:00)
            TimeSpan t2 = TimeSpan.FromHours(1.5);

            //Converte minutos para o formato do TimeSpan (00:01:30)
            TimeSpan t3 = TimeSpan.FromMinutes(1.5);

            //Converte segundos para o formato do TimeSpan (00:00:01:5000000)
            TimeSpan t4 = TimeSpan.FromSeconds(1.5);

            //Converte milissegundos para o formato do TimeSpan (00:00:00:0015000)
            TimeSpan t5 = TimeSpan.FromMilliseconds(1.5);

            //Converte ticks para o formato do TimeSpan (00:01:30)
            TimeSpan t6 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
        }
    }
}
