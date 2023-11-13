using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserSimulator
{
    public class StringStack
    {
        public string[] values;
        public int index;

        public StringStack() 
        {
            //in constructor string[] values creates a new string for inside constructor only
            values = new string[10];
        }
        
        //push add to stack
        public void Push(string value) 
        {
            //this.values array || [index++] index +1 || index++ 0 / +1 || ++index 1 / +1 
            this.values[index++] = value;
        }

        //pop remove from stack
        public string Pop()
        {
            if (index == 0)
            {
                Console.WriteLine("There are no URLs left in the Stack");
                return ("ERROR 404");
            } else
            {
                // return this.values[index--] does also work
                index--;
                return this.values[index];
            }
        }

        public string Peek()
        { 
            return this.values[index--];
        }

        public void Swap()
        {
            string tempIndex = this.values[index-1];
            this.values[index - 1] = this.values[index - 2];
            this.values[index - 2] = tempIndex;
        }

        public void Clear()
        {
            Array.Clear(values, 0, values.Length);
            index = 0;
        }

        public bool IsEmpty {  get { return index == 0; } }

        public int Count { get { return values.Length; } }

        public bool IsFull => index == values.Length;
    }
}
