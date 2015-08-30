using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem012;

namespace Problem012Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TriangleNumberTests()
        {
            var result = Program.TriangleNumber(2);
            Console.WriteLine(result);
        }
    }
}
