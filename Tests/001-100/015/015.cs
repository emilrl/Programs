using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _015_Lattice_Paths;

namespace Tests._001_100._015
{
    [TestClass]
    public class _015
    {
        [TestMethod, TestCategory("Answer")]
        public void _015LatticePaths()
        {
            var result = Class1.LatticePaths(20);
            Console.WriteLine(result);
        }
    }
}
