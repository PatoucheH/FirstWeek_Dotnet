using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.FourthExercise
{
    internal class Car2
    {
        private Engine _engine;
        
        public Car2(Engine engine)
        {
            _engine = engine;
        }

        public void Start()
        {
            Console.WriteLine("Car is starting !");
            _engine.Function();
        }
    }
}
