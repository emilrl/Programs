using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem010;

namespace Tests._010
{
    [TestClass]
    public class Problem010Tests
    {
        [TestMethod, TestCategory("Answer")]
        public void _010PrimeSumTests()
        {
            var result = Program.PrimeSum(2000000);
            Console.WriteLine(result);
        }
    }
}
