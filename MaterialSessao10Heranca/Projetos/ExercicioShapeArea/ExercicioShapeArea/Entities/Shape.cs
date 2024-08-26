using System;
using System.Collections.Generic;
using ExercicioShapeArea.Entities.Enums;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioShapeArea.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
             Color = color;
        }

        public abstract double Area();
    }
}
