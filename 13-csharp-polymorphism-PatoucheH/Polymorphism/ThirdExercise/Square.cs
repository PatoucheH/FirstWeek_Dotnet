using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.ThirdExercise
{
    internal class Square : Shape
    {
        public double _side;
        public Square(double side) { _side = side; }

        public override double CalculateArea()
        {
            return Math.Pow(_side, 2);
        }

        public override void Paint(string color)
        {
            Console.WriteLine($"The square has been colored in {color}");
        }
    }
}
