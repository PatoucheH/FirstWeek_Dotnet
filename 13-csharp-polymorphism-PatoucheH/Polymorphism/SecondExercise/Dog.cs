using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.SecondExercise
{
    internal class Dog : IAnimal
    {
        public void MakeNoise()
        {
            Console.WriteLine("Barks");
        }
    }
}
