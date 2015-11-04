using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _017_Number_letter_count;

namespace Tests._001_100._017
{
    [TestClass]
    public class _017
    {
        [TestMethod, TestCategory("Check")]
        public void TestTens()
        {
            var result = Class1.NumToStringTens(16);
            Console.WriteLine(result);
        }

        [TestMethod, TestCategory("Check")]
        public void ResultListTests()
        {
            var result = Class1.NumberLengthListTens();
            foreach (var n in result)
            {
                Console.WriteLine(n);
            }
        }

        [TestMethod, TestCategory("Check")]
        public void CharacterCountTests()
        {
            var result = Class1.CharacterCount(999);
            Console.WriteLine(result);
        }
        //[TestMethod, TestCategory("Check")]
        //public void ResultListTests()
        //{
        //    var result = Class1.NumberList(99);
        //    foreach (var n in result)
        //    {
        //        Console.WriteLine(n);
        //    }
        //}
    }
}
