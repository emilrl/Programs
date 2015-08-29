using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static long TriangleNumber(long maxDivisorCount)
        {
            long divisorCount = 0;
            long i = 1;
            long j = 2;
            while (divisorCount < maxDivisorCount)
            {
                var divisors = 0;
                var kMax = i/2;
                for (var k = 2; k < kMax; k++)
                {
                    if (i%k == 0)
                    {
                        divisors++;
                    }
                }
                divisors ++;
                i =+ j;
                j++;

                divisorCount = divisors;
            }
            return j;
        }
    }
}
