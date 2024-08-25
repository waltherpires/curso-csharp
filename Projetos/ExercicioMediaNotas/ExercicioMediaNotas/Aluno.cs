using System;
using System.Globalization;

namespace ExercicioMediaNotas
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public string Status()
        {
            if(NotaFinal() >= 60)
            {
                return "APROVADO";
            }
            else
            {
                double margem = 60 - NotaFinal();
                return "REPROVADO \n" +
                "FALTARAM " + margem.ToString("F2", CultureInfo.InvariantCulture) +  " PONTOS";
            }
        }
    }
}
