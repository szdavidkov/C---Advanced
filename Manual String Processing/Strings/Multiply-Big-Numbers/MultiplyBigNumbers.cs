using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SumBigNumbers
{
    public class SumBigNumbers
    {
        public static void Main()
        {
            string firstNum = GetTheNum();
            int multiplier = int.Parse(Console.ReadLine());

            StringBuilder sum = MultiplyNumbers(firstNum, multiplier);

            Console.WriteLine(sum);
        }

        private static string GetTheNum()
        {

            string num = Console.ReadLine();
            if (num.Length > 1)
            {
                num = num.TrimStart(new char[] { '0' });
            }
            return num;
        }

        private static StringBuilder MultiplyNumbers(string firstNum, int multiplier)
        {
            StringBuilder result = new StringBuilder();
            int temp = 0;
            int digitSum = 0;
            int miltiplied = 0;
            for (int i = 0; i < firstNum.Length; i++)
            {
                int nextDigit = int.Parse(firstNum[firstNum.Length - i - 1].ToString());
                miltiplied = nextDigit * multiplier + temp;
                if (i == firstNum.Length - 1)
                {
                    result.Insert(0, miltiplied.ToString());
                    return result;
                }
                digitSum = miltiplied % 10;
                temp = miltiplied / 10;

                result.Insert(0, digitSum.ToString());
            }
            return result;
        }
    }
}