using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class BasicProblems
    {
        /// <summary>
        /// Find factorial of a number
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int FindFactorial(int n)
        {
            if (n == 0)
                return 1;

            int result = 1;


            for (int i = n; i > 0; i--)
            {
                result = result * i;
            }

            return result;

        }

        /// <summary>
        /// Swap 2 numbers without using a temp variable
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void SwapNumbers(int a, int b)
        {

            Console.WriteLine("before swaping a=" + a + " b=" + b);

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("after swaping a=" + a + " b=" + b);
        }

        /// <summary>
        /// Find bracket combinations based on number
        /// For size 2 valid combinations 
        /// (()) 
        /// ()() 
        /// For size 3 valid combinations 
        /// ((()))",
        /// (()())
        /// (())()
        /// ()(())
        /// ()()()
        /// </summary>
        private void BracketCombinations(string str, int open, int close)
        {
            if (open == 0 && close == 0)
                Console.WriteLine(str);

            if (open > close)
                return;

            if (open > 0)
                BracketCombinations(str + "(", open - 1, close);

            if (close > 0)
                BracketCombinations(str + ")", open, close - 1);
        }

        public void BracketCombinations(int n)
        {
            BracketCombinations("", n, n);
        }

        public static int solution(int n)
        {
            int product = 1;
            int sum = 0;
            while (n > 0)
            {
                int val = n % 10;
                product = product * val;
                sum = sum + val;
                n = n / 10;
            }
            return product - 21;
        }

        public int PatternMatch(string pattern, string s)
        {
            if (pattern.Length == s.Length)
            {
                if (IsVowel(s[0]))
                {
                    if (pattern[0] != '0')
                        return 0;
                    else
                        return 1;
                }
                else
                {
                    if (pattern[0] != '1')
                        return 0;
                    else
                        return 1;
                }
            }

            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int j = i;

                if (j == s.Length - 1)
                    break;

                for (int k = 0; k < pattern.Length; k++)
                {
                    if (IsVowel(s[j]))
                    {
                        if (pattern[k] != '0')
                            break;
                    }
                    else
                    {
                        if (pattern[k] != '1')
                            break;
                    }

                    if (k == pattern.Length - 1)
                        count++;
                    j++;
                }
            }

            return count;
        }

        public bool IsVowel(char c)
        {
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'y';
        }

        public bool StrictlyIncreasing(int[] sequence)
        {
            int n = sequence.Length;

            // Stores the count of numbers that
            // are needed to be removed
            int count = 0;

            // Store the index of the element
            // that needs to be removed
            int index = -1;

            // Traverse the range [1, N - 1]
            for (int i = 1; i < n; i++)
            {

                // If arr[i-1] is greater than
                // or equal to arr[i]
                if (sequence[i - 1] >= sequence[i])
                {

                    // Increment the count by 1
                    count++;

                    // Update index
                    index = i;
                }
            }

            // If count is greater than one
            if (count > 1)
                return false;

            // If no element is removed
            if (count == 0)
                return true;

            // If only the last or the
            // first element is removed
            if (index == n - 1 || index == 1)
                return true;

            // If a[index] is removed
            if (sequence[index - 1] < sequence[index + 1])
                return true;

            // If a[index - 1] is removed
            if (sequence[index - 2] < sequence[index])
                return true;

            return false;

        }

        //public bool BeautifulString(string inputString)
        //{
        //    int[] map = new int[256];

        //    for (int i = 0; i < inputString.Length; i++)
        //    {
        //        map[inputString[i]]++;
        //    }

        //    // we will start from ascii value for b which is 98 and end at ascii value for z which is 122
        //    for (int i = 98; i <= 122; i++)
        //    {
        //        if (map[i] > map[i - 1])
        //            return false;
        //    }

        //    return true;
        //}

        //public bool solution(string[] words, string variableName)
        //{
        //    string word = "";

        //    for (int i = 0; i < variableName.Length; i++)
        //    {
        //        if ((i > 0 && char.IsUpper(variableName[i])) || (i == variableName.Length - 1))
        //        {
        //            if((i == variableName.Length - 1))
        //                word = word + variableName[i];

        //            if (isWordFound(words, word))
        //            {
        //                word = "";
        //                word = word + variableName[i];
        //            }
        //            else
        //                return false;
        //        }
        //        else
        //            word = word + variableName[i];
        //    }

        //    return true;
        //}

        //private bool isWordFound(string[] words, string word)
        //{
        //    for (int i = 0; i < words.Length; i++)
        //    {
        //        if (string.Equals(words[i], word, StringComparison.InvariantCultureIgnoreCase))
        //            return true;
        //    }
        //    return false;
        //}
    }
}
