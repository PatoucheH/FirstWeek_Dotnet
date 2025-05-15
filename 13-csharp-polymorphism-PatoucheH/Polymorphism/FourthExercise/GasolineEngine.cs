using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.FourthExercise
{
    internal class GasolineEngine : Engine
    {
        public override void Function()
        {
            Console.WriteLine("This engine runs on gasoline.");
        }
    }
}
