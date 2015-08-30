using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem456;

namespace Tests._456
{
    [TestClass]
    public class PointTests
    {
        [TestMethod, TestCategory("Check")]
        public void _456Test100_100()
        {
            var point = new Point(100, 100);
            Assert.AreEqual(Math.PI / 4, point.A);
        }
        [TestMethod, TestCategory("Check")]
        public void _456Test100_N100()
        {
            var point = new Point(100, -100);
            Assert.AreEqual(7*Math.PI / 4, point.A);
        }
        [TestMethod, TestCategory("Check")]
        public void _456TestN100_100()
        {
            var point = new Point(-100, 100);
            Assert.AreEqual(3 * Math.PI / 4, point.A);
        }
        [TestMethod, TestCategory("Check")]
        public void _456TestN100_N100()
        {
            var point = new Point(-100, -100);
            Assert.AreEqual(5 * Math.PI / 4, point.A);
        }
        [TestMethod, TestCategory("Check")]
        public void _456TestN100_0()
        {
            var point = new Point(-100, 0);
            Assert.AreEqual(Math.PI, point.A);
        }
        [TestMethod, TestCategory("Check")]
        public void _456Test100_0()
        {
            var point = new Point(100, 0);
            Assert.AreEqual(0, point.A);
        }
        [TestMethod, TestCategory("Check")]
        public void _456Test0_100()
        {
            var point = new Point(0, 100);
            Assert.AreEqual(2 * Math.PI / 4, point.A);
        }
        [TestMethod, TestCategory("Check")]
        public void _456Test0_N100()
        {
            var point = new Point(0, -100);
            Assert.AreEqual(6 * Math.PI / 4, point.A);
        }
    }
}
