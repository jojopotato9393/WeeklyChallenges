using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (startNumber % n == 0)
            {

            return startNumber + n;
            }
            int diff = n - (startNumber % n);
            return startNumber + diff;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var business in businesses)
            {
               if(business.TotalRevenue <= 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)

        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            return numbers.SequenceEqual(numbers.OrderBy(x => x));
        }        
        

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            if(numbers == null || numbers.Length == 0) 
            { return 0; }
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i + 1];
                }
            
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
           
            if (words == null || words.All(w => string.IsNullOrWhiteSpace(w)))
            {
                return "";
            }        
            var sentence = string.Join(" ", words
                                            .Where(w => !string.IsNullOrWhiteSpace(w))
                                            .Select(w => w.Trim()));

            return string.IsNullOrEmpty(sentence) ? "" : $"{sentence}.";

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if(elements == null || elements.Count == 0)
            {
                return new double[0];
            }
            return elements.Where((element, index) => (index + 1) % 4 == 0).ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for(int i = 0; i < nums.Length;i++)
            {
                for (int k =i +1; k < nums.Length;k++)
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
