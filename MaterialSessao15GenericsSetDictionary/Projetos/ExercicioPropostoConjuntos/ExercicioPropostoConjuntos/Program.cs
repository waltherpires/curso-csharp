
using System.Collections;

namespace ExercicioPropostoConjuntos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> cursoA = new HashSet<int>();
            HashSet<int> cursoB = new HashSet<int>();
            HashSet<int> cursoC = new HashSet<int>();

            Console.Write("How many students fo course A? ");
            int qtda = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtda; i++) 
            {
                int aluno = int.Parse(Console.ReadLine());
                cursoA.Add(aluno);
            }

            Console.Write("How many students fo course B? ");
            int qtdb = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtdb; i++)
            {
                int aluno = int.Parse(Console.ReadLine());
                cursoB.Add(aluno);
            }

            Console.Write("How many students fo course C? ");
            int qtdc = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtdc; i++)
            {
                int aluno = int.Parse(Console.ReadLine());
                cursoC.Add(aluno);
            }

            HashSet<int> total = new HashSet<int>(cursoA);
            total.UnionWith(cursoB);
            total.UnionWith(cursoC);

            Console.WriteLine(total.Count);
        }
    }
}
