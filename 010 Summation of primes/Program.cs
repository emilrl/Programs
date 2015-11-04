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
            long result = 2;
            for (var i = 3; i < max; i += 2)
            {
                var isPrime = Problem007.Program.NumberIsPrime(i);
                if (isPrime)
                {
                    result += i;
                }
            }
            return result;
        }
    }



}
