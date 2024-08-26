namespace IntrodMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];


            // Diz a quantidade de elementos da matriz
            Console.WriteLine(mat.Length);

            //primeira dimensao da matriz -> qtd de linhas
            Console.WriteLine(mat.Rank);

            //Diz o tamanho da dimensao que for escolhida (no caso, a 0)
            Console.WriteLine(mat.GetLength(1));
        }
    }
}
