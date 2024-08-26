using System;

namespace ExercicioQuartosVetor
{
    internal class Aluguel
    {
        public string Name { get; private set; }
        public string Email { get; private set; }

        public Aluguel(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Name}, {Email}";
        }
    }
}
