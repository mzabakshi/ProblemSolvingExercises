using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class StringProblems
    {
        /// <summary>
        /// Write a function to check if the string is unique or not
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool UniqueString(string str)
        {
            //string sortedStr = String.Concat(str.OrderBy(x => x));
            char[] charArr = str.ToCharArray();
            Array.Sort<char>(charArr);

            for (int i = 0; i < charArr.Length; i++)
            {
                if (i + 1 == charArr.Length)
                    break;
                if (charArr[i] == charArr[i + 1])
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Find if the string is unique wihtout sorting
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool UniqueStringWithoutsorting(string str)
        {
            char[] array = str.ToCharArray();

            int[] count = new int[256];

            for (int i = 0; i < str.Length; i++)
            {
                count[array[i]]++;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (count[array[i]] > 1)
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Is a String Palindrom
        /// noon, civic, radar
        /// </summary>
        public bool IsPalindrom(string str)
        {
            char[] charList = str.ToCharArray();
            int length = charList.Length;

            for (int i = 0, j = length - 1; i < length; i++, j--)
            {
                if (charList[i] != charList[j])
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Write a simple code for finding the most repeated character in given string by sorting
        /// </summary>
        /// <param name="str"></param>
        public void MostRepeatedCharacter(string str)
        {
            char[] array = str.ToCharArray();

            Array.Sort(array);

            int count = 1;
            int max = 1;
            char maxChar = array[1];

            for (int i = 1; i < array.Length; i++)
            {
                count = array[i] == array[i - 1] ? count + 1 : 1;

                if (count > max)
                {
                    max = count;
                    maxChar = array[i];
                }
            }

            Console.WriteLine("Max occured character: " + maxChar + " -- Occured: " + max);

        }


        /// <summary>
        /// Write a simple code for finding the most repeated character in given string without sorting
        /// </summary>
        /// <param name="str"></param>
        public void MostRepatedCharacterWithoutsorting(string str)
        {
            char[] array = str.ToCharArray();

            int ASCII_SIZE = 256;
            int[] count = new int[ASCII_SIZE];

            for (int i = 0; i < array.Length; i++)
            {
                count[array[i]]++;
            }

            int max = -1;
            char maxChar = ' ';

            for (int i = 0; i < array.Length; i++)
            {
                if (count[array[i]] > max)
                {
                    max = count[array[i]];
                    maxChar = array[i];
                }
            }

            Console.WriteLine("Max occured character: " + maxChar + " -- Occured: " + max);

        }

        /// <summary>
        /// Write a function to reverse the order of words in a string?
        /// </summary>
        public void ReverseWordInString(string str)
        {
            string[] words = str.Split(' ');
            StringBuilder sb = new StringBuilder();

            for (int i = words.Length - 1; i > -1; i--)
            {
                sb.Append(words[i]);
                sb.Append(" ");
            }

            Console.WriteLine(sb);
        }

        /// <summary>
        /// Check if two strings are anagram i.e Myspace can be rearranged to be Spacemy
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        public void IsAnagram(string str1, string str2)
        {
            if (str1.Length == str2.Length)
            {
                //str1.ToLower();
                //str2.ToLower();

                char[] ch1 = str1.ToLower().ToCharArray();
                char[] ch2 = str2.ToLower().ToCharArray();

                Array.Sort(ch1);
                Array.Sort(ch2);

                if (ch1.SequenceEqual(ch2))
                {
                    Console.WriteLine("The strings are an anagram");
                }
                else
                {
                    Console.WriteLine("Not an anagram");
                }
            }
            else
            {
                Console.WriteLine("Not an anagram");
            }
        }

        /// <summary>
        /// Check if two strings are anagram i.e Myspace can be rearranged to be Spacemy
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        public bool CheckAnagram(string str1, string str2)
        {
            char[] ch1 = str1.ToLower().ToArray();
            char[] ch2 = str2.ToLower().ToArray();

            if (ch1.Length != ch2.Length)
                return false;

            int[] count1 = new int[256];
            int[] count2 = new int[256];

            for (int i = 0; i < ch1.Length && i < ch2.Length; i++)
            {
                count1[ch1[i]]++;
                count2[ch2[i]]++;
            }

            for (int i = 0; i < ch1.Length && i < ch2.Length; i++)
            {
                if (count1[ch1[i]] != count2[ch2[i]])
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Given a pattern and a string str, find if str follows the same pattern.
        /// pattern = "abba", str = "dog cat cat dog" should return true.
        /// pattern = "abba", str = "dog cat cat fish" should return false.
        /// pattern = "aaaa", str = "dog cat cat dog" should return false.
        /// pattern = "abba", str = "dog dog dog dog" should return false.
        /// </summary>
        /// <param name="pattern"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool WordPattern(string pattern, string str)
        {
            string[] result = str.Split(' ');
            Dictionary<char, string> dict = new Dictionary<char, string>();

            if (pattern.Length != result.Length)
                return false;

            string value;
            for (int i = 0; i < result.Length; i++)
            {
                if (dict.TryGetValue(pattern[i], out value))
                {
                    if (value != result[i])
                        return false;
                }
                else
                {
                    if (dict.ContainsValue(result[i]))
                        return false;
                    dict.Add(pattern[i], result[i]);
                }
            }

            return true;

        }

        public void RemoveDuplicateCharInPlace(string str)
        {
            HashSet<char> hash = new HashSet<char>();

            for (int i = 0; i < str.Length; i++)
            {
                hash.Add(str[i]);
            }

            foreach (var h in hash)
            {
                Console.Write(h);
            }
        }

        // Example: force -> Kforce
        public string InsertKBeforeF(string str)
        {
            LinkedList<char> list = new LinkedList<char>();

            foreach (var item in str)
            {
                if (item == 'f' || item == 'F')
                {
                    list.AddLast('K');
                    list.AddLast(item);
                }
                else
                    list.AddLast(item);
            }

            string res = "";
            foreach (var item in list)
            {
                res += item;
            }

            return res;
        }
    }
}
