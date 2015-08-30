using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem009;

namespace Problem009Tests
{
    [TestClass]
    public class Project009Tests
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

        [TestMethod]
        public void TestPytTripProd()
        {
            var product = Program.PytTripProd(1000);
            Console.WriteLine(product);
        }
    }
}
