using System;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Versioning;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _018_Maximum_path_sum_I;

namespace Tests
{
    [TestClass]
    public class _018
    {
        [TestMethod, TestCategory("Check")]
        public void ReadingFromFileTest()
        {
            var result = Class1.ReadLinesFromFile(@"../../Resources/TextFile1.txt");
            foreach (var n in result)
            {
                Console.WriteLine(n);
            }
        }

        [TestMethod, TestCategory("Check")]
        public void StringListToIntsTests()
        {
            var result = Class1.StringListToInts(Class1.ReadLinesFromFile(@"../../Resources/TextFile1.txt"));
            foreach (var n in result)
            {
                foreach (var m in n)
                {
                    Console.WriteLine(m);
                }
            }
        }

        [TestMethod, TestCategory("Answer")]
        public void FastestPathTest()
        {
            var result = Class1.FastestPath(Class1.StringListToInts(Class1.ReadLinesFromFile(@"../../Resources/TextFile1.txt")));
            Console.WriteLine(result);
        }

        [TestMethod, TestCategory("Check")]
        public void HighestTest()
        {
            var result = Class1.ReadLinesFromFile(@"../../Resources/TextFile1.txt");
            
            foreach (var n in result)
            {
                Console.WriteLine(n);
            }
        }
    }
}
