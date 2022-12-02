using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int remainder;
            int quotient = Math.DivRem(startNumber, n, out remainder);

            return (quotient +1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
           for (int i = 0; i< businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                     businesses[i].Name = "CLOSED";
                }
            }

        }

        public bool IsAscendingOrder(int[] numbers)
        {   
           if (numbers == null || numbers.Length == 0)
                return false;
                
           for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
                else
                {
                    
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) { return 0; }
            int sum = 0;

                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i - 1] % 2 == 0)
                    {
                        sum += numbers[i];
                    }
                }

                return sum;
            
            //if (numbers == null || numbers.Length == 0) { return 0; }

            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        sum += numbers[i + 1];
            //    }

            //}
            //return sum;
        }    

        public string TurnWordsIntoSentence(string[] words)
        {



        if (words == null || words.Length == 0)
            {
                return "";
            }
            //var wordSentence = Regex.Replace(words.ToString(), ", ", "");
            var sentence = "";
            foreach (var word in words)
            {
                if (word.Trim().Length > 0)
                {
                    sentence += word.Trim() + " ";
                }

            }
            if (sentence.Length == 0)
            {
                return "";
            }
            sentence = sentence.Trim();
            sentence += ".";
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
           

            if (elements == null)
            {
                return new double[0];
            }
            List<double> fourthList = new List<double>();


            for (int i = 3; i < elements.Count; i += 4)
            {
                fourthList.Add(elements[i]);
                
                
            }
            return fourthList.ToArray();
        }    

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = i + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[k] == targetNumber)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
