using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Longest_Collatz_sequence
{
    public class Class1
    {
        public static long Even(long number)
        {
            return number/2;
        }

        public static long Uneven(long number)
        {
            return (number*3) + 1;
        }

        public static long LongestCollatz(long belowNumber)
        {
            var collatzList = new long[(belowNumber), 3];
            long longestNum = 0;
            long longestLength = 0;
            for (long i = 0; i < belowNumber; i++)
            {
                long j = i;
                long count = 1;
                while (j > 1)
                {
                    if (j < i)
                    {
                        count = count + collatzList[j, 1];
                        break;
                    }
                    if (j % 2 == 0)
                    {
                        j = Even(j);
                        count++;
                    }
                    else
                    {
                        j = Uneven(j);
                        count++;
                    }
                }
                collatzList[i, 0] = i;
                collatzList[i, 1] = count-1;
                collatzList[i, 2] = count;
                if (count < longestLength) continue;
                longestNum = i;
                longestLength = count;
            }
            return collatzList[longestNum,0];
        }
    }
}
