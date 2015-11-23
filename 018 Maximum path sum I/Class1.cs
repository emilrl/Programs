using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace _018_Maximum_path_sum_I
{
    //Text file with values to solve problem is contained in the Tests.
    public class Class1
    {
        public static IEnumerable<string> ReadLinesFromFile(string fileName)
        {
            var list = new List<string>();
            using (var reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }
            return list;
        }

        public static List<List<int>> StringListToInts(IEnumerable<string> stringList)
        {
            return stringList.Select(line => line.Split(' ').Select(int.Parse).ToList()).ToList();
        }

        public static List<List<int>> StringListToIntsAlt(IEnumerable<string> stringList)
        {
            var resultList = new List<List<int>>();
            foreach (var line in stringList)
            {
                var numbers = line.Split(' ').Select(Int32.Parse).ToList();
                resultList.Add(numbers);
            }
            return resultList;
        }

        public static int FindHighest(int a1, int b1, int b2)
        {
            var result = a1 + Math.Max(b1, b2);
            return result;
        }

        public static int FastestPath(List<List<int>> numbersList)
        {
            var resultList = new List<int>();
            var calcList = new List<List<int>>();
            calcList = numbersList;
            for (var i = (numbersList.Count - 1); i > 0; i--)
            {
                for (var j = 1; j < numbersList[i].Count; j++)
                {
                    var result = FindHighest(calcList[(i - 1)][(j - 1)], calcList[i][(j - 1)], calcList[i][j]);
                    calcList[(i - 1)][(j - 1)] = result;
                    resultList.Add(result);
                }
            }
            return resultList[(resultList.Count - 1)];
        }
    }
}