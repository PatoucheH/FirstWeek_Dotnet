using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.SecondExercise
{
    internal class Cat :IAnimal
    {
        public void MakeNoise()
        {
            Console.WriteLine("Meows");
        }
    }
}
