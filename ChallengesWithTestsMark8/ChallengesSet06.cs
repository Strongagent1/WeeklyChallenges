using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;
            if(string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }
            if (ignoreCase == true)
            {
                word =word.ToLower();
                List<string> lc = words.Select(x => x.ToLower()).ToList();

                containsWord = lc.Contains(word);
            }
            if (ignoreCase == false)
            {
                containsWord = words.Contains(word);
            }
            else
            {
                return containsWord;
            }
            return (ignoreCase) ? words.Select(x=>x.ToLower()).Contains(word) : words.Contains(word);
            
            //if (words.Contains(word) && ignoreCase == true)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        public bool IsPrimeNumber(int num)
        {
            if (num == 2 || num == 3)
            {
                return true;
            }
            if (num % 2 == 0 || num % 3 == 0 || num <= 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            return str.IndexOf(str.Distinct().Reverse().Where(x => str.Where(y => y.Equals(x)).Count() == 1).FirstOrDefault());
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;

            for (var i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;

                for (var j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }
                    currentCount++;
                }

                if (currentCount > count)
                {
                    count = currentCount;
                }
            }
            return count;
            
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double>nthElement = new List<double>();

            if (elements == null || n <= 0 || n > elements.Count)
            {
                return nthElement.ToArray();
            }
            for (var i = n - 1; i < elements.Count; i += n) 
            {
                nthElement.Add(elements[i]);    
            }
            return nthElement.ToArray();
        }
    }
    
}
