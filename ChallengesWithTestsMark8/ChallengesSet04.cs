using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.InteropServices;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var result = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    result += number;
                }
                else
                {
                    result -= number;
                }
            }
            return result;

        }
        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<string> shortString = new List<string>();
            shortString.Add(str1);
            shortString.Add(str2);
            shortString.Add(str3);
            shortString.Add(str4);
            return (char)shortString.Min().Count();

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var minNumber = new int[] { number1, number2, number3, number4 };
            return minNumber.Min();
        }




        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {

            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            var result = (sideLength1 + sideLength2 > sideLength3 && sideLength3 + sideLength1 > sideLength2) && sideLength2 + sideLength3 > sideLength1 ? true : false;
            return result;
        }

        public bool IsStringANumber(string input)
        {
            if (double.TryParse(input, out double value))
            {
                return true;
            }
            return false;


        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return Convert.ToDouble(objs.Where(x => x == null).Count()) / Convert.ToDouble(objs.Length) > 0.5;

            //int itemCount = objs.Length;
            //int nullCount = 0;
            //var majority = (objs.Length / 2)+1;
            //foreach (object obj in objs)
            //{
            //    if (obj == null)
            //    {
            //        nullCount++;


            //    }
            //    else if (obj != null)
            //    {

            //        itemCount++;
            //    }
            //    else if (nullCount > itemCount)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }




            //if (itemCount <= nullCount)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int evenSum = 0;
            int evenCount = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    evenSum += i;
                    evenCount++;
                }
            }
            if (evenCount == 0)
            {
                return 0;
            }
            return (double)evenSum / evenCount;
            //if (numbers == null || numbers.Length == 0)
            //{
            //    return 0;
            //}
            //var evenAvg = numbers.Where(x => x % 2 == 0).Average();
            //if (evenAvg.ToString().Length == 0)
            //{
            //    return 0;
            //}

            //else
            //{
            //    return evenAvg;
            //}
        }

        public int Factorial(int number)
        {
            if (number < 0) throw new ArgumentOutOfRangeException();
            if(number == 0) return 1;
            if(number > 1)
            {
                return number * Factorial(number - 1);
            }
            else
            {
                return number;
            }
            //int result = number;
            

            //for (int i = 1; i <= number; i++)
            //{
            //    result = result *= i;
            //}
            //return result;
        }

    }
}