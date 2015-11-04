using System;
using System.CodeDom;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem456
{
    public static class PointFactory
    {
        public static IEnumerable<Point> P(long n)
        {
            var modResultX = 1248;
            var modResultY = 8421;
            for (var i = 1; i <= n; i++)//point iterations
            {
                if (i > 1)
                {
                    modResultX = (modResultX * 1248) % 32323;
                    modResultY = (modResultY * 8421) % 30103;
                }
                yield return new Point(modResultX - 16161, modResultY - 15051);
            }
        }
    }
}
