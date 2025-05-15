using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.FirstExercise
{
    internal class Motorcycle : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("The motorcycle starts with a loud rev.");
        }
    }
}
