using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if(words == null || word == null) return false;
            if (ignoreCase)
            {
              
                return words.Any(w => string.Equals(w, word, StringComparison.OrdinalIgnoreCase));
            }
            else
            {
              
                return words.Contains(word);
            }




        }

        public bool IsPrimeNumber(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0) return false;
            }  
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
           Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char x in str)
            {
                if (charCount.ContainsKey(x))
                {
                    charCount[x]++;
                }
                else
                {
                    charCount.Add(x, 1);
                }
            }
            for (int i = str.Length - 1; i >= 0; i--) {
                if (charCount[str[i]] == 1)
                {
                    return i;
                }
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
           
               
                if (numbers == null || numbers.Length == 0)
                    return 0;

             
                int maxConsecutiveCount = 1;
                int currentCount = 1;

              
                for (int i = 1; i < numbers.Length; i++)
                {
                    
                    if (numbers[i] == numbers[i - 1])
                    {
                        currentCount++;
                    }
                    else
                    {
                    
                        maxConsecutiveCount = Math.Max(maxConsecutiveCount, currentCount);
                      
                        currentCount = 1;
                    }
                }

                
                maxConsecutiveCount = Math.Max(maxConsecutiveCount, currentCount);  
                return maxConsecutiveCount;
            

        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || elements.Count == 0 || n <= 0)
            {
                return new double[0];
            }

            List<double> resultList = new List<double>();
           
            for (int i = n - 1; i < elements.Count; i += n)
            {
                resultList.Add(elements[i]);
            }

            return resultList.ToArray();
        }
    }
}
