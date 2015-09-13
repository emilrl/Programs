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
        public static int Even(int number)
        {
            return number/2;
        }

        public static int Uneven(int number)
        {
            return (number*3) + 1;
        }

        public static int LongestCollatz(int belowNumber)
        {
            var collatzList = new int[(belowNumber), 3];
            var longestNum = 0;
            var longestLength = 0;
            for (var i = 0; i < belowNumber; i++)
            {
                var j = i;
                var count = 1;
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
