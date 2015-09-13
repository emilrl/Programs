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
            var result = Class1.LongestCollatz(1000000);
            Console.WriteLine(result);
        }

        //[TestMethod]
        //public void TestMethod1()
        //{
        //    var result = Class1.LongestCollatz(14);
        //    foreach (var n in result)
        //    {
        //        Console.WriteLine(n);
        //    }
            
        //}
    }
}
