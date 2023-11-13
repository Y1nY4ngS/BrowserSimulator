using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class GenericStack<T>
    {
        public T[] values;
        public int index;
        public GenericStack()
        {
            values = new T[10];
        }

        public void Push(T value)
        {
            this.values[index++] = value;
        }

        public T Pop()
        {
            index--;
            return this.values[index];
        }
        
        public bool IsEmpty {

            get { 
            return index == 0;
            }
        }

    }
}
