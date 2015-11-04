using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_Number_letter_count
{
    public static class Class1
    {
        public static string NumToStringOnes(int one)
        {
            string result = "";
            if (one == 0)
            {
                result = "";
            }
            if (one == 1)
            {
                result = "One";
            }
            if (one == 2)
            {
                result = "Two";
            }
            if (one == 3)
            {
                result = "Three";
            }
            if (one == 4)
            {
                result = "Four";
            }
            if (one == 5)
            {
                result = "Five";
            }
            if (one == 6)
            {
                result = "Six";
            }
            if (one == 7)
            {
                result = "Seven";
            }
            if (one == 8)
            {
                result = "Eight";
            }
            if (one == 9)
            {
                result = "Nine";
            }
            return result;
        }

        public static string NumToStringTensHelper(int ten)
        {
            string result = "";
            if (ten == 1)
            {
                result = "Teen";
            }
            if (ten == 2)
            {
                result = "Twenty";
            }
            if (ten == 3)
            {
                result = "Thirty";
            }
            if (ten == 4)
            {
                result = "Forty";
            }
            if (ten == 5)
            {
                result = "Fifty";
            }
            if (ten == 6)
            {
                result = "Sixty";
            }
            if (ten == 7)
            {
                result = "Seventy";
            }
            if (ten == 8)
            {
                result = "Eighty";
            }
            if (ten == 9)
            {
                result = "Ninety";
            }
            return result;
        }


        public static string NumToStringTens(int number)
        {
            string result = "";
            if (number < 10)
            {
                result = NumToStringOnes(number);
            }
            if (number == 10)
            {
                result = "Ten";
            }
            if (number == 11)
            {
                result = "Eleven";
            }
            if (number == 12)
            {
                result = "Twelve";
            }
            if (number == 13)
            {
                result = "Thirteen";
            }
            if (number == 14)
            {
                result = "Fourteen";
            }
            if (number == 15)
            {
                result = "Fifteen";
            }
            if (number >= 16 && number < 20)
            {
                if (number == 18)
                {
                    result = "Eighteen";
                }
                else
                {
                    result = NumToStringOnes(number % 10) + NumToStringTensHelper(number / 10);
                }
            }
            if (number >= 20 && number < 100)
            {
                if (number%10 == 0)
                {
                    result = NumToStringTensHelper(number/10);
                }
                else
                {
                    result = NumToStringTensHelper(number/10) + NumToStringOnes(number%10);
                }
            }
            return result;
        }

        public static int[,] NumberLengthListTens()
        {
            var maxNumber = 99;
            var stringList = new List<string>();
            var resultList = new int[maxNumber,2];
            for (var i = 1; i <= maxNumber; i++)
            {
                stringList.Add(NumToStringTens(i));
            }
            for (var j = 1; j <= maxNumber; j++)
            {
                resultList[(j - 1), 0] = j;
                resultList[(j - 1), 1] = stringList[(j - 1)].Length;
            }
            return resultList;
        }

        public static int CharacterCount(int maxNumber)
        {
            var result = 0;
            var tenLength = NumberLengthListTens();
            for (var i = 1; i <= maxNumber; i++)
            {
                if (i%100 == 0 && i >= 100)
                {
                    result += NumToStringOnes(i/100).Length + 7;
                }
                if (i < 100)
                {
                    result += tenLength[(i - 1), 1];
                }
                if (i % 100 != 0 && i >= 100)
                {
                    result += NumToStringOnes(i/100).Length + 10 + tenLength[((i - 1)%100), 1];
                }
            }
            return result + "OneThousand".Length;
        }
    }
}
