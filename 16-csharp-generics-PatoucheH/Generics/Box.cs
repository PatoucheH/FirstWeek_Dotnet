using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Box <T>
    {
        public T? _item { get; private set; }

        public Box (T item)
        {
            _item = item;
        }

        public void DisplayValue()
        {
            Console.WriteLine(_item);
        }

        public (T, T) Swap(ref T a, ref T b)
        {
            T transitionVariable = a;

            a = b;
            b = transitionVariable;

            return (a, b);
        }


    }
}
