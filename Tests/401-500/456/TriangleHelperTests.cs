using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem456;

namespace Tests._456
{
    [TestClass]
    public class TriangleHelperTests
    {
        [TestMethod, TestCategory("Validation")]
        public void _456TestC8()
        {
            Assert.AreEqual(20, TriangleHelper.C(8));
        }
        [TestMethod, TestCategory("Validation")]
        public void _456TestC600()
        {
            Assert.AreEqual(8950634, TriangleHelper.C(600));
        }
        
        [TestMethod, TestCategory("Validation")]
        public void _456TestC40000()
        {
            Assert.AreEqual(2666610948988, TriangleHelper.C(40000));
        }
        [TestMethod, TestCategory("Answer")]
        public void _456TestC2000000()
        {
            Assert.AreEqual(2666610948988, TriangleHelper.C(2000000));
        }
    }
}
