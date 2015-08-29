using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem12;

namespace Problem12Tests
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
