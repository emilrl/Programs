using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem012
{
    public class Program
    {
        public static int TriangleNumber(int maxDivisorCount)
        {
            var divisorCount = 0;
            var i = 1;
            var j = 2;
            while (divisorCount < maxDivisorCount)
            {
                i = i + j;
                j++;
                var divisors = DivisorCounter(i);

                divisorCount = divisors;
            }
            return i;
        }

        public static int DivisorCounter(int i)
        {
            var divisors = 0;
            for (var k = 1; k <= (Math.Sqrt(i)); k++)
            {
                if (i % k == 0)
                {
                    divisors += 2;
                }
            }
            return divisors;
        }
    }
}