using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrowserSimulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace BrowserSimulator.Tests
{
    [TestClass()]
    public class StringStackTests
    {
        [TestMethod()]
        public void StringStackTest()
        {
            var stack = new StringStack();
        }

        [TestMethod()]
        public void PushTest()
        {
            //arrrange
            var stack = new StringStack();
            //act
            stack.Push("string1");
            stack.Push("string2");
            //assert
            Assert.AreEqual(2, stack.values);
        }

        [TestMethod()]
        public void PopTest()
        {
            //arrrange
            var stack = new StringStack();
            //act
            stack.Push("string1");
            stack.Push("string2");
            stack.Pop();
            //assert
            Assert.AreEqual(1, stack.values);
        }

        [TestMethod()]
        public void PeekTest()
        {
            //arrrange
            var stack = new StringStack();
            //act
            stack.Push("string1");
            stack.Push("string2");
            //assert
            Assert.AreEqual("string2", stack.Pop());
            Assert.AreEqual("string2", stack.Peek());
        }

        [TestMethod()]
        public void SwapTest()
        {
            //arrrange
            var stack = new StringStack();
            //act
            stack.Push("strin1");
            stack.Push("string2");
            stack.Swap();
            //assert
            Assert.AreEqual("string1", stack.Pop());
            Assert.AreEqual("string2", stack.Pop());
        }

        [TestMethod()]
        public void ClearTest()
        {
            //arrrange
            var stack = new StringStack();
            //act
            stack.Push("string1");
            stack.Push("string2");
            stack.Push("string3");
            stack.Clear();
            //assert
            Assert.IsTrue(stack.IsEmpty);
        }
    }
}