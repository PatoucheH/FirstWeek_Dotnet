using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.FirstExercise
{
    internal class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("The car starts with a roar.");
        }
    }
}
