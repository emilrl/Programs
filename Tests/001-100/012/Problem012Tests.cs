using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem012;

namespace Tests._012
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod, TestCategory("Check")]
        public void _012TriangleNumberTests()
        {
            var result = Program.TriangleNumber(2);
            Console.WriteLine(result);
        }

        [TestMethod, TestCategory("Answer")]
        public void _012TriangleNumberTests5()
        {
            var result = Program.TriangleNumber(500);
            Console.WriteLine(result);
        }
    }
}
