using System.IO;
using System.Globalization;
using ExercicioFixacao.Entities;

namespace ExercicioFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file full path: ");
            string sourceFilePath = Console.ReadLine(); 
           
            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summmary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using(StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(",");
                        string name = fields[0];
                        double value = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int qtd = int.Parse(fields[2]);

                        Item item = new Item(name, value, qtd);

                        sw.WriteLine(item.Name + "," + item.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
