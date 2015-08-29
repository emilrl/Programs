using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project009
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static int PytTripProd(int sum)
        {
            int c;
            for (c = 3; c < (sum/2); c++)
            {
                int a;
                for (a = 1; a < ((sum/2) - 2); a++)
                {
                    var b = sum - (a + c);
                    if (a + b > (sum/2) && a + b + c == 1000 && Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                    {
                        return a*b*c;
                    }
                }
            }
            return 0;
        }

        //public static List<double> MakePowList(int c)
        //{
        //    var maxPow = c;
        //    var powList = new List<double>();
        //    for (double i = 1; i <= Math.Sqrt(maxPow); i++)
        //    {
        //        powList.Add(Math.Pow(i, 2));
        //    }
        //    return powList;
        //}
    }
}
