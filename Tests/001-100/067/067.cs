using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _018_Maximum_path_sum_I;

namespace Tests._001_100._067
{
    [TestClass]
    public class _067
    {
        [TestMethod, TestCategory("Answer")]
        public void FastestPath2Test()
        {
            var result = Class1.FastestPath(Class1.StringListToInts(Class1.ReadLinesFromFile(@"../../Resources/TextFile2.txt")));
            Console.WriteLine(result);
        }

    }
}
