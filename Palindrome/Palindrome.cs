using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Palindrome
{
    internal class Palindrome
    {
        private GenericStack<string> stack = new GenericStack<string>();

        public bool IsPalindrome(string value)
        {
            
            foreach (char c in value)
            {
                stack.Push(value);
            }
            
            while (!stack.IsEmpty)
            {
                stack.Pop();
            }
            return true;
        }
    }
}
