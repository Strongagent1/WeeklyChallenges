using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Xml.Schema;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (char.IsLetter(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            //var answer = vals.Length % 2 == 0 ? "True" : "False";
            //Console.WriteLine(answer);

            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsNumberOdd(int num)
        {
            if ((num % 2) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else if (!numbers.Any())
            {
                return 0;
            }
            else
            {
                double min = numbers.Min();
                double max = numbers.Max();

                return min + max;
            }






        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return str2.Length;
            }
            else
            {
                return str1.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                return numbers.Sum();
            }

        }

        public int SumEvens(int[] numbers)
        {
            
            
            
            if (numbers == null)
            {
                return 0;
            }          
            
            var evenTotal = numbers.Where(x => x % 2 == 0).Sum();
            return evenTotal;

            //int? value = 0;
            /*
            int sum = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                int val = numbers[i];
                if (numbers == null) 
                {

                    return 0; 
                }
                
                else if (val % 2 == 0)
                {
                    sum += val;
                    return sum;
                   
                }
            }*/


        }

        public double CountOfPositiveOddsBelowNumber(int number)
        {
            var oddCount  = Enumerable.Range(1, number).Where(num => num % 2 != 0);
            return oddCount.Count();
        }
    }
}
