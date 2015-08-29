using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem456;

namespace Problem456Tests
{
    [TestClass]
    public class PointFactoryTests
    {
        [TestMethod]
        public void TestP()
        {
            var list = PointFactory.P(10).ToList();
            foreach (var point in list)
            {
                Console.WriteLine(point.A);
            }
        }
        [TestMethod]
        public void TestPSorted2000000()
        {
            var list = PointFactory.P(10).OrderBy(p => p.A).ToList();
            foreach (var point in list)
            {
                Console.WriteLine(point.A);
            }
        }
    }
}
