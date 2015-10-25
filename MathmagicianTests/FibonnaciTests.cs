using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathmagician;

namespace MathmagicianTests
{
    [TestClass]
    public class FibonnaciTests
    {
        [TestMethod]
        public void FibEnsureICanCreateClassInstance()
        {
            FibNumbers fib = new FibNumbers();
            Assert.IsNotNull(fib);
        }

        [TestMethod]
        public void FibShouldPrintFirstNumber()
        {
            FibNumbers fib = new FibNumbers();
            int expected = 1;
            int actual = fib.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibShouldPrintNextNumber()
        {
            FibNumbers fib = new FibNumbers();
            int input = 4;
            int expected = 5;
            int actual = fib.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibShouldPrintSequenceOfNumbers()
        {
            FibNumbers fib = new FibNumbers();
            int[] expected = new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            int[] actual = fib.GetSequence();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibShouldPrintAVariableSequenceOfNumbers()
        {
            FibNumbers fib = new FibNumbers();
            int input = 12;
            int[] expected = new int[] {1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };
            int[] actual = fib.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibPrintSequenceOfNumbers()
        {
            FibNumbers fib = new FibNumbers();
            int length = 7;
            string expected = "1 1 2 3 5 8 13";
            string actual = fib.ToString(fib.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }
    }
}
