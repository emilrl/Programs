using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem006
{
    class Program
    {
        private static void Main(string[] args)
        {
            long n = 100;
            Console.Write(SquareSum(n) - SumSquares(n));
            Console.ReadKey();
        }

        public static long SumSquares(long n)
        {
            long result = 0;
            for (var i = 1; i <= n; i++)
            {
                result = result + Convert.ToInt64(Math.Pow(i, 2));
            }
            return result;
        }

        public static long SquareSum(long n)
        {
            long sum = 0;
            for (var i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            return Convert.ToInt64(Math.Pow(sum, 2));
        }
    }
}
