namespace ExercicioPropostoDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Enter file full path:");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))

                {
                    Dictionary<string, int> register = new Dictionary<string, int>();
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int votes = int.Parse(line[1]);

                        if (register.ContainsKey(name))
                        {
                            register[name] += votes;
                        }
                        else
                        {
                            register[name] = votes;
                        }
                    }
                    foreach (KeyValuePair<string, int> pair in register)
                    {
                        Console.WriteLine(pair.Key + ": " + pair.Value);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
