using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Problem011
{
    public class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            var list2 = list.ToArray();
            var test = new int[20, 20];
            for (var i = 0; i < 20; i++)
            {
                for (var j = 0; j < 20; j++)
                {
                    test[i, j] = list[i*20 + j];
                }
            }
        }

        public static List<int> MakeNumbersList(string strNumbers)
        {
            var numbersList = new List<int>();
            string[] words = strNumbers.Split(' ');
            foreach (string word in words)
            {
                int intWord = 0;
                int.TryParse(word, out intWord);
                numbersList.Add(intWord);
            }
            return numbersList;
        }

        public static int[,] ListToArray(List<int> numbers, int a, int b)
        {
            var list = new List<int>();
            list = numbers;
            var list2 = new int[a, b];
            for (var i = 0; i < a; i++)
            {
                for (var j = 0; j < b; j++)
                {
                    list2[i, j] = list[i * b + j];
                }
            }
            return list2;
        }

        public static int MaxProdFour(int[,] numberArray)
        {
            var list = new int[20, 20];
            list = numberArray;
            var maxProd = 0;
            var i = 0;
            var j = 0;
            for (i = 0; i < 20; i++)
            {

                for (j = 0; j < 20; j++)
                {
                    //downward diagonal
                    if (i + 3 < 20 && j + 3 < 20)
                    {
                        var a = list[i, j];
                        var b = list[i + 1, j + 1];
                        var c = list[i + 2, j + 2];
                        var d = list[i + 3, j + 3];
                        var prod = a*b*c*d;
                        if (prod > maxProd)
                        {
                            maxProd = prod;
                        }
                    }

                    //upward diagonal
                    if (i + 3 < 20 && j - 3 > 0)
                    {
                        var a = list[i, j];
                        var b = list[i + 1, j - 1];
                        var c = list[i + 2, j - 2];
                        var d = list[i + 3, j - 3];
                        var prod = a * b * c * d;
                        if (prod > maxProd)
                        {
                            maxProd = prod;
                        }
                    }

                    //horizontal
                    if (i + 3 < 20)
                    {
                        var a = list[i, j];
                        var b = list[i + 1, j];
                        var c = list[i + 2, j];
                        var d = list[i + 3, j];
                        var prod = a * b * c * d;
                        if (prod > maxProd)
                        {
                            maxProd = prod;
                        }
                    }

                    //vertical
                    if (j + 3 < 20)
                    {
                        var a = list[i, j];
                        var b = list[i, j + 1];
                        var c = list[i, j + 2];
                        var d = list[i, j + 3];
                        var prod = a * b * c * d;
                        if (prod > maxProd)
                        {
                            maxProd = prod;
                        }
                    }
                }
            }
            return maxProd;
        }
    }
}
