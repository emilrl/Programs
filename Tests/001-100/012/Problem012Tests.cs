using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem012;

namespace Tests._012
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod, TestCategory("Answer")]
        public void _012TriangleNumberTests5()
        {
            var result = Program.TriangleNumber(500);
            Console.WriteLine(result);
        }

        [TestMethod, TestCategory("Check")]
        public void _012TriangleNumberTests200()
        {
            var result = Program.TriangleNumber(200);
            Console.WriteLine(result);
        }

        [TestMethod, TestCategory("Check")]
        public void _012DivisorCounterTests6()
        {
            var result = Program.DivisorCounter(6);
            Console.WriteLine(result);
        }

        [TestMethod, TestCategory("Check")]
        public void _012DivisorCounterTests10()
        {
            var result = Program.DivisorCounter(10);
            Console.WriteLine(result);
        }

        [TestMethod, TestCategory("Check")]
        public void _012DivisorCounterTests15()
        {
            var result = Program.DivisorCounter(15);
            Console.WriteLine(result);
        }

        [TestMethod, TestCategory("Check")]
        public void _012DivisorCounterTests28()
        {
            var result = Program.DivisorCounter(495);
            Console.WriteLine(result);
        }

        [TestMethod, TestCategory("Check")]
        public void _012TriangleNumberFinderTests()
        {
            var result = Program.TriangleNumberFinder(1);
            Console.WriteLine(result);
        }
    }
}
