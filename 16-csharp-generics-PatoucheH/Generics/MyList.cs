using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MyList<T>
    {
        internal List<T> list = [];

        public void Add(T item)
        {
            list.Add(item);
        }

        public T Get(int index)
        {
            if(index < 0 || index >= list.Count)
            {
                throw new IndexOutOfRangeException("Index out of the range of the list");
            }
            else
            {
                return list[index];
            }
        }
    }
}
