using System;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var sum = 0;
            ;
           foreach (int number in numbers)
            {
               if (number % 2 == 0)
                {
                    sum += number;
                  
                }
               else 
                {
                    sum -= number;
                 
                }
              
            }
           return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int minLength = Math.Min(Math.Min(str1.Length, str2.Length), Math.Min(str3.Length, str4.Length));
            return minLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] numbers = { number1, number2, number3, number4 };
            int smallNum = numbers.Min();
            return smallNum;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            // tri inequality theorem a + b > c
            int[] sides = new[] { sideLength1, sideLength2, sideLength3 };
            Array.Sort(sides);
            return sides[0] + sides[1] > sides[2];
        }

        public bool IsStringANumber(string input)
        {
            bool result = double.TryParse(input, out _);
            return result;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {

            var nullCount = objs.Count(obj => obj == null);
            return nullCount > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0; 
            }

           
            var average = numbers.Where(n => n % 2 == 0).DefaultIfEmpty(0).Average();

            return average;
        }
       
        public int Factorial(int number)
        {

            
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Factorial not defined for negative num");
            }
            if (number == 0)
            {
                return 1;
            }

            return number * Factorial(number - 1);
        }
    }
}
