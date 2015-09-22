using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Problem013;

namespace _016_Power_digit_sum
{
    public class Class1
    {
        public static List<int> LargeExponentOfTwo(int exponent)
        {
            // Convert start base to a list of one-digit ints.
            var Base = Problem013.Class1.StringToIntList(2.ToString());
            var exp = exponent;
            // Summing the list of ints with itself the exponent number of times.
            for (var i = 1; i < exponent; i++)
            {
                var newBase = new List<int>();
                bool rest = false;
                for (var j = (Base.Count - 1); j >= 0; j--)
                {
                    // Calculating the part sum.
                    var partSum = Base[j]*2;
                    // Adding the rest from previous calculation.
                    if (rest)
                    {
                        partSum++;
                        rest = false;
                    }
                    // If part sum is below 10.
                    if (partSum < 10)
                    {
                        Base[j] = partSum;
                    }
                    // If part sum is 10 or higher and not first in the list.
                    if (partSum >= 10 && j > 0)
                    {
                        rest = true;
                        Base[j] = partSum - 10;
                    }
                    // If part sum is 10 or higher and first in the list
                    if (partSum >= 10 && j == 0)
                    {
                        // Making new list of two digit first number, and constructing a new list incorporating it into the base list.
                        var digitList = Problem013.Class1.StringToIntList(partSum.ToString());
                        newBase = Enumerable.Repeat(0, (Base.Count + 1)).ToList();
                        for (var k = 0; k <= Base.Count; k++)
                        {
                            if (k == 0 || k == 1)
                            {
                                newBase[k] = digitList[k];
                            }
                            else
                            {
                                newBase[k] = Base[k - 1];
                            }
                        }
                    Base = newBase;
                    }
                }
            }
            return Base;
        }

        public static int AddListDigits(List<int> intList)
        {
            var sum = 0;
            for (var i = 0; i < intList.Count; i++)
            {
                sum += intList[i];
            }
            return sum;
        }
    }
}
