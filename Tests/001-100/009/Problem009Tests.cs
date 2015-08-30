using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem009;

namespace Tests._009
{
    [TestClass]
    public class Problem009Tests
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    var list = Program.MakePowList(1000);
        //    foreach (var i in list)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        [TestMethod, TestCategory("Answer")]
        public void _009TestPytTripProd()
        {
            var product = Program.PytTripProd(1000);
            Console.WriteLine(product);
        }
    }
}
