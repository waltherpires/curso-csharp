using System;

using GetHashCodeEEquals.Entities;

namespace GetHashCodeEEquals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com"};
            Client b = new Client { Name = "Alex", Email = "maria@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b); // Compara a referencia do ponteiro de objeto
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
