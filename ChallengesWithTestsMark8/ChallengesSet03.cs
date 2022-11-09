using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);

            /*b
             if (vals.Contains(False)
             {
                 return true;
             }
             else
             {
                 return false;    
             }*/
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {

            if (numbers == null)
            {
                return false;
            }

            var oddTotal = numbers.Where(x => x % 2 != 0).Sum();
           
            if (oddTotal % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
            //var result = numbers.Sum()
            

        }
        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit) ? true : false); 
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return (divisor == 0) ? 0 : dividend / divisor;

        }
        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
          var odds = Enumerable.Range(1, 100).Where(num => num %2 != 0);
            return odds.ToArray();
        }
        
            
        

        public void ChangeAllElementsToUppercase(string[] words)
        {

            
            foreach (var word in words)
            {
                for (int i = 0; i < words.Length; i++)
                    words[i] = words[i].ToUpper();

            }
        }

    }
}

