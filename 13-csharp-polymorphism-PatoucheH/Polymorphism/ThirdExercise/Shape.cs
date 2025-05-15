using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.ThirdExercise
{
    internal abstract class Shape : IPaintable
    {
        public abstract double CalculateArea();

        public abstract void Paint(string color);
    }
}
