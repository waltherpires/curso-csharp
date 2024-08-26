using System;
using System.Collections.Generic;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();


            //Adiciona ao final
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            //Adiciona na posicao indicada
            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: " + list.Count);

            // Encontra a primeira ocorrencia
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro 'A': " + s1);

            // Encontra a ultima ocorrencia
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultimo 'A': " + s2);

            // Encontra a posicao da primeira ocorrencia
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira posicao comecando com A: " + pos1);

            //Encontra a posicao da ultima ocorrencia
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultima posicao comecando com A: " + pos2);

            //Cria uma nova lista que obedeca o predicado utilizado (FIlTRO)
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            //Remover da lista(apenas 1)
            list.Remove("Alex");
            Console.WriteLine("--------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Remove todos que corresponderem ao predicado
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("--------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

        }

    }
}
