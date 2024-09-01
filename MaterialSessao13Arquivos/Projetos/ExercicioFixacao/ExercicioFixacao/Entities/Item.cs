using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFixacao.Entities
{
    internal class Item
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public int Quantity { get; set; }

        public Item(string name, double value, int quantity)
        {
            Name = name;
            Value = value;
            Quantity = quantity;
        }

        public double Total()
        {
            return Value * Quantity;
        }
    }
}
