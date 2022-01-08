using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class CodesignalProblems
    {
        public int CodebotsAvailableRooms(int[][] matrix)
        {
            int sum = 0;
            int length = matrix[0].Length;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    int val = matrix[j][i];
                    if (val < 1)
                        break;

                    sum += val;
                }
            }

            return sum;
        }

        public string[] LongestStringFromArray(string[] inputArray)
        {
            int max = 0;
            int length = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length > max)
                {
                    max = inputArray[i].Length;
                    length = 1;
                }
                else if (inputArray[i].Length == max)
                    length++;
            }

            var arr = new string[length];
            int j = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length == max)
                {
                    arr[j++] = inputArray[i];
                }
            }

            return arr;
        }

        public int NumberOfCommonCharacters(string s1, string s2)
        {
            var dictionary1 = new Dictionary<char, int>();
            var dictionary2 = new Dictionary<char, int>();
            int sum = 0;

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == ' ')
                    continue;

                if (dictionary1.ContainsKey(s1[i]))
                    dictionary1[s1[i]]++;
                else
                    dictionary1[s1[i]] = 1;
            }

            for (int i = 0; i < s2.Length; i++)
            {
                if (s2[i] == ' ')
                    continue;

                if (dictionary2.ContainsKey(s2[i]))
                    dictionary2[s2[i]]++;
                else
                    dictionary2[s2[i]] = 1;
            }

            foreach (var kvp1 in dictionary1)
            {
                if (!dictionary2.ContainsKey(kvp1.Key))
                    continue;

                var kvp2Val = dictionary2[kvp1.Key];

                if (kvp1.Value > kvp2Val)
                    sum += kvp2Val;
                else
                    sum += kvp1.Value;
            }

            return sum;
        }

        bool LuckyNumber(int n)
        {
            int length = n.ToString().Length;
            int first = 0;
            int second = 0;
            int count = 0;

            while (n > 0)
            {
                int val = n % 10;

                if (count < length / 2)
                    second += val;
                else
                    first += val;

                count++;
                n = n / 10;
            }

            return first == second;
        }
    }
}
