using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.ThirdExercise
{
    internal class Circle : Shape
    {
        public double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }
    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }

    public override void Paint(string color)
    {
        Console.WriteLine($"The circle has been colored in {color}");
    }
}
}
