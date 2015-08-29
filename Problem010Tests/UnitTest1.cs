using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem010;

namespace Problem010Tests
{
    [TestClass]
    public class Problem010Tests
    {
        [TestMethod]
        public void PrimeSumTests()
        {
            var result = Program.PrimeSum(2000000);
            Console.WriteLine(result);
        }
    }
}
