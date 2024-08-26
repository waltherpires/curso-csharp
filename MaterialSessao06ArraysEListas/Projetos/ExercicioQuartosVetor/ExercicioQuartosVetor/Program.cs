namespace ExercicioQuartosVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluguel[] alugueis = new Aluguel[9];

            Console.WriteLine("Quantos quartos vao ser alugados?");
            int quartosAlugados = int.Parse(Console.ReadLine());

            for(int i = 0; i < quartosAlugados; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Aluguel #1:");
                Console.Write("Name:");
                string nome = Console.ReadLine();
                Console.Write("Email:");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                alugueis[quarto] = new Aluguel(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Salas ocupadas:");
            for(int i = 0; i < alugueis.Length; i++)
            {
                if (alugueis[i] != null)
                {
                    Console.WriteLine(i + ": " + alugueis[i]);
                }
            } 
        }
    }
}
