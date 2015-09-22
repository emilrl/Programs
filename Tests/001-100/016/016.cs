using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _016_Power_digit_sum;

namespace Tests._001_100._016
{
    [TestClass]
    public class _016
    {
        [TestMethod, TestCategory("Check")]
        public void LargeExponentTests5()
        {
            var result = Class1.LargeExponentOfTwo(5);
            foreach (var n in result)
            {
                Console.WriteLine(n);
            }
        }

        [TestMethod, TestCategory("Check")]
        public void LargeExponentTests10()
        {
            var result = Class1.LargeExponentOfTwo(1000);
            foreach (var n in result)
            {
                Console.WriteLine(n);
            }
        }

        [TestMethod, TestCategory("Check")]
        public void AddDigitListTests5()
        {
            var result = Class1.AddListDigits(Class1.LargeExponentOfTwo(5));
            Console.WriteLine(result);
        }

        [TestMethod, TestCategory("Answer")]
        public void AddDigitListTests1000()
        {
            var result = Class1.AddListDigits(Class1.LargeExponentOfTwo(1000));
            Console.WriteLine(result);
        }
    }
}
