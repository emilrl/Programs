using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem456
{
    public static class TriangleHelper
    {
        public static long C(long n)
        {
            long result = 0;
            var points = PointFactory.P(n).OrderBy(point => point.A).ToList();
            var invIndexes = new InvIndex[points.Count];
            Parallel.For(0, points.Count, i =>
            {
                var max = GetInverseIndex(points, i, false);
                var min = (max - 1)%points.Count;
                invIndexes[i] = new InvIndex(min, max); 
            });
            invIndexes = invIndexes.OrderBy(i => i.Min).ToArray();

            long lastSum = 0;
            for (var i = 1; i < invIndexes.Count(); i++)
            {
                lastSum += invIndexes[i].Min - invIndexes[0].Max + 1;
            }
            var totalSum = lastSum;
            for (var i = 1; i < invIndexes.Count(); i++)
            {
                if (invIndexes[i].Min == invIndexes[i - 1].Min && invIndexes[i].Max == invIndexes[i - 1].Max)
                {
                    continue;
                }
                lastSum -= (invIndexes[i].Min - invIndexes[i - 1].Max + 1)* (invIndexes.Count() - i);
                totalSum += lastSum;
            }
            return totalSum;




            //for (var i = 0; i < points.Count; i++)
            //{
            //    for (var j = i + 1; j < points.Count; j++)
            //    {
            //            result += invIndexes[j].Min  > invIndexes[i].Max 
            //                ? invIndexes[j].Min - invIndexes[i].Max
            //                : invIndexes[j].Min + points.Count - invIndexes[i].Max;
            //    }
            //}
            //return result;
        }

        private static int GetInverseIndex(IReadOnlyList<Point> list, int origIndex, bool origIsMax)
        {
            var invA = list[origIndex].InvA;
            var minIndex = 0;
            var maxIndex = list.Count - 1;
            var foundIt = false;
            while (maxIndex - minIndex > 1)
            {
                var testIndex = minIndex + (maxIndex - minIndex)/2;
                if (list[testIndex].A > invA)
                {
                    maxIndex = testIndex;
                }
                else
                {
                    minIndex = testIndex;
                }

            }
            if (!origIsMax)
            {
                minIndex = (minIndex + 1)%list.Count;
            }
            return minIndex;


        }
    }
}
