using System.Globalization;

namespace ExercicioMatrizResolvido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("De o valor de N: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for(int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i,j] = int.Parse(values[j]);
                }
            }
   
            Console.WriteLine("Diagonal Principal: ");
            for(int i = 0; i < matriz.Length; i++)
            {
                Console.Write(matriz[i,i] + " ");
            }

            Console.WriteLine();
            Console.Write("Numeros negativos: ");
            int numerosNegativos = 0;
            foreach (int obj in matriz)
            {
                if(obj < 0)
                {
                    numerosNegativos++;
                }
            }
            Console.WriteLine(numerosNegativos);
        }
    }
}
