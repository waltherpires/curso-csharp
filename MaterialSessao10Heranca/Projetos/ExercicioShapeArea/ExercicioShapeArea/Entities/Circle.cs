using System;
using System.Collections.Generic;
using ExercicioShapeArea.Entities.Enums;
using ExercicioShapeArea.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioShapeArea.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
