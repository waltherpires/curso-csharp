using System;
using System.Numerics;

namespace OperadoresDeAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a++;
            
            Console.WriteLine(a);
            Console.WriteLine(b);
            b /= 2;
            Console.WriteLine(b);
            b *= 5;
            Console.WriteLine(b);
            b += 3;
            Console.WriteLine(b);
            b -= 1;
            Console.WriteLine(b);
        }
    }
}