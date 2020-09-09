using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if(char.IsLetter(c))
                {
                return true;
                }
            return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length %2 ==0;
        }

        public bool IsNumberEven(int number)
        {
           if (number %2==0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count<double>() == 0)
            {
                return 0;
            }
            else
            {
                var max = numbers.Max();

                var min = numbers.Min();

                return (max + min);
            }
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length>str2.Length)
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
             return   numbers.Sum();
            }
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            var a = 0;
            foreach (var x in numbers)
            {
                if (x%2==0)
                {
                    a += x;
                }
            }
            return a;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null || numbers.Count ==0)
            {
                return false;
            }
            else if(numbers.Sum()%2!=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number < 0)
            {
                return 0;
            }

            return number / 2;

        }
    }
}
