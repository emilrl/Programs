using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem013
{
    public static class Class1
    {
        /// <summary>
        /// Takes a string of a number and turns it into a list of single digits.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static List<int> StringToIntList(string number)
        
        {
            var intList = new List<int>();
            string numString = number;
            char[] charList = numString.ToCharArray();
            foreach (var Char in charList)
            {
                intList.Add((int)Char.GetNumericValue(Char));
            }
            return intList;
        }

        /// <summary>
        /// Takes two lists of digit and sums them as two big numbers.
        /// </summary>
        /// <param name="addList1"></param>
        /// <param name="addList2"></param>
        /// <returns></returns>
        public static List<int> SumLists(List<int> addList1, List<int> addList2)
        {
            var result = addList1;
            var add = addList2;
            bool rest = false;
            for (var i = (result.Count - 1); i >= 0; i--)
            {
                result[i] = result[i] + add[i];
                if (rest)
                {
                    result[i]++;
                }
                rest = false;
                if (result[i] >= 10 && i > 0)
                {
                    rest = true;
                    result[i] = result[i]%10;
                }
            }
            return result;
        }

        public static List<int> AddLists(int[,] addArray, int colLength, int rowLength)
        {
            var resultList = Enumerable.Repeat(0, rowLength).ToList();
            var array = addArray;
            for (var i = 0; i < colLength; i++)
            {
                var addList = new List<int>();
                for (var j = 0; j < rowLength; j++)
                {
                    addList.Add(array[i,j]);
                }
                resultList = SumLists(resultList, addList);
            }
            return resultList;
        }
    }
}
