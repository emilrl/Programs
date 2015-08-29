using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem456;

namespace Problem456Tests
{
    [TestClass]
    public class TriangleHelperTests
    {
        [TestMethod]
        public void TestC8()
        {
            Assert.AreEqual(20, TriangleHelper.C(8));
        }
        [TestMethod]
        public void TestC600()
        {
            Assert.AreEqual(8950634, TriangleHelper.C(600));
        }
        
        [TestMethod]
        public void TestC40000()
        {
            Assert.AreEqual(2666610948988, TriangleHelper.C(40000));
        }
        [TestMethod]
        public void TestC2000000()
        {
            Assert.AreEqual(2666610948988, TriangleHelper.C(2000000));
        }
    }
}
