using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _015_Lattice_Paths
{
    public class Class1
    {
        public static long LatticePaths(int sideLength)
        {
            long count = 0;
            var paths = new long[sideLength-1];
            for (long i = 0; i <= sideLength; i++)
            {
                if (i == 0)
                {
                    count++;
                }
                if (i == 1)
                {
                    for (long l = 0; l < sideLength - 1; l++)
                    {
                        paths[l] = 1;
                        count++;
                    }
                }

                if (i <= 1) continue;
                for (long j = 1; j < sideLength; j++)
                {
                    long factorCount = 0;
                    for (long k = (j - 1); k < sideLength - 1; k++)
                    {
                        factorCount = factorCount + paths[k];
                    }
                    paths[j - 1] = factorCount;
                    count += factorCount;
                }
            }
            return count * 2;
        }
    }
}
