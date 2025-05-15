using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Greeter <T>  where T : IHasName
    {
        public string Name { get; set; }

        public void Greet (T person) 
        {
            Console.WriteLine($"Hello, {person.Name}");
        }
    }
}
