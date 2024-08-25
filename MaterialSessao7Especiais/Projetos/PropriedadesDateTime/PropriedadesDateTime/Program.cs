namespace PropriedadesDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            //Data em formato longo
            Console.WriteLine(d.ToLongDateString());

            //Horario em formato longo
            Console.WriteLine(d.ToLongTimeString());

            //Data em formato resumido
            Console.WriteLine(d.ToShortDateString());

            //Horario em formato resumido
            Console.WriteLine(d.ToShortTimeString());

            //Mascara de formatacao
            Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss.fff"));

            //Imprime apenas a data, desconsidera o resto
            Console.WriteLine("1) Date: " + d.Date);

            //Imprime apenas o Dia
            Console.WriteLine("2) Day: " + d.Day);

            //Imprime o dia da semana
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);

            //Dia do Ano
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);

            //Hora
            Console.WriteLine("5) Hour: " + d.Hour);

            //Tipo: Local ou Universal
            Console.WriteLine("6) Kind: " + d.Kind);

            //Milissegundos
            Console.WriteLine("7) Millisecond:" + d.Millisecond);

            //Minutos
            Console.WriteLine("8) Minute: " + d.Minute);

            //Mes
            Console.WriteLine("9) Month: " + d.Month);

            //Segundos
            Console.WriteLine("10) Second: " + d.Second);

            //Qtd de Ticks
            Console.WriteLine("11) Ticks: " + d.Ticks);

            //Horario do Dia
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);

            //Ano
            Console.WriteLine("13) Year: " + d.Year);
        }
    }
}
