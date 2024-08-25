using System;

namespace ConversaoImplicaeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //conversao implicita
            float x = 4.5f;
            double y = x;
            Console.WriteLine(y);

            double a;
            float b;
            //conversao casting (downcast)
            a = 5.1;
            b = (float)a;
            Console.WriteLine(b);

            int n = 5;
            int m = 2;

            //conversao casting (upcasting)
            double resultado = (double)n / m;
            Console.WriteLine(resultado);
        }
    }
}
