using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem456;

namespace Tests._456
{
    [TestClass]
    public class PointFactoryTests
    {
        [TestMethod, TestCategory("Check")]
        public void _456TestP()
        {
            var list = PointFactory.P(10).ToList();
            foreach (var point in list)
            {
                Console.WriteLine(point.A);
            }
        }
        [TestMethod, TestCategory("Check")]
        public void _456TestPSorted2000000()
        {
            var list = PointFactory.P(10).OrderBy(p => p.A).ToList();
            foreach (var point in list)
            {
                Console.WriteLine(point.A);
            }
        }
    }
}
