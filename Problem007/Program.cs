using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem007
{
    public class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine(Prime(100001));
            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedMilliseconds + " ms");
            Console.ReadKey();
        }

        public static bool NumberIsPrime(long n)
        {
            var sqrt = Convert.ToInt64(Math.Sqrt(n));
            var isPrime = true;
            for (long i = 2; i <= sqrt; i++)
            {
                if (n%i != 0) continue;
                isPrime = false;
                break;
            }
            return isPrime;
        }

        public static long Prime(int n)
        {
            var count = 1;
            long i = 1;
            while (count < n)
            {
                i += 2;
                if (NumberIsPrime(i))
                {
                    count++;
                }

            }
            return i;
        }
    }
}
