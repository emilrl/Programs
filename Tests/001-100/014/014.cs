using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _014_Longest_Collatz_sequence;

namespace Tests._001_100
{
    [TestClass]
    public class _014
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = Class1.LongestCollatz(13);
            Console.WriteLine(result);
        }
    }
}
