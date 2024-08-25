namespace ModificadoresRefEOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            //Sem o ref o valor da variavel mudaria apenas dentro do escopo da classe
            //O valor continuara sendo 10 se ref nao for utilizado
            //obs: ref exige que a variavel seja iniciada.
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            //out nao precisa que a variavel seja iniciada.
            int b = 10;
            int triple;
            Calculator.TripleOut(b, out triple);
            Console.WriteLine(triple);
        }
    }
}
