using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem007;

namespace Problem010
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static long PrimeSum(long max)
        {
            var lastPrime = 0;
            long result = 0;
            for (var i = 3; i < max; i += 2)
            {
                bool isPrime = Problem007.Program.NumberIsPrime(i);
                if (isPrime)
                {
                    result += i;
                    lastPrime = i;
                }
            }
            return result + 2;
        }
    }



}
