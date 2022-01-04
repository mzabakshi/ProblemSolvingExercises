using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class ArrayProblems
    {

        /// <summary>
        /// Find the pair of element produces largest sum in the given array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int FindLargestPairSum(int[] arr)
        {
            int first, second;

            if (arr[0] > arr[1])
            {
                first = arr[0];
                second = arr[1];
            }
            else
            {
                first = arr[1];
                second = arr[0];
            }

            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] > first)
                {
                    second = first;
                    first = arr[i];
                }
                else if (arr[i] > second && arr[i] != first)
                {
                    second = arr[i];
                }
            }

            return first + second;
        }

        /// <summary>
        /// Find the sequence of elements produces largest sum in the given array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int FindLargestSumSequence(int[] arr)
        {
            int size = arr.Length;

            int maxSoFar = 0;
            int maxEnding = 0;

            for (int i = 0; i < size; i++)
            {
                maxEnding += arr[i];

                if (maxSoFar < maxEnding)
                    maxSoFar = maxEnding;

                if (maxEnding < 0)
                    maxEnding = 0;
            }
            return maxSoFar;
        }

        /// <summary>
        /// Write a program to calculate max sum sub array from a given array and also give their positions
        /// </summary>
        /// <returns></returns>
        public void FindMaxSumSubArrayWithPositions(int[] arr)
        {
            // Note: position isnt working correctly 
            int maxSoFar = int.MinValue;
            int endOfMax = 0;
            int[] positions = new int[arr.Length];
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                endOfMax += arr[i];
                positions[index] = i;
                index++;

                if (maxSoFar < endOfMax)
                    maxSoFar = endOfMax;
                if (endOfMax < 0)
                {
                    endOfMax = 0;
                    index = 0;
                    positions = new int[arr.Length];
                }

            }

            Console.WriteLine("Max subarray sum " + maxSoFar);
            Console.Write("Max subarray sum positions ");
            for (int i = 0; i < positions.Length; i++)
            {
                Console.Write(positions[i] + ", ");
            }
        }

        /// <summary>
        /// Write a function to find the most frequent element in an array
        /// </summary>
        /// <param name="arr"></param>
        public void MostFrequentElementUsingLINQ(int[] arr)
        {
            var groups = arr.GroupBy(x => x);
            var frequent = groups.OrderByDescending(x => x.Count()).First();
            Console.WriteLine("The most frequent number is " + frequent.Key + " with occurences " + frequent.Count());
        }

        /// <summary>
        /// Write a function to find the most frequent element in an array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int MostFrequentElementInArray(int[] arr)
        {
            int[] count = new int[256];

            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i]]++;
            }

            int maxcount = 0;
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (count[arr[i]] > maxcount)
                {
                    maxcount = count[i];
                    max = arr[i];
                }
            }

            return max;
        }

        /// <summary>
        /// Find 2nd highest number in an array
        /// </summary>
        public void FindSecondHighestNumber(int[] arr)
        {
            int first = int.MinValue;
            int second = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > first)
                {
                    second = first;
                    first = arr[i];
                }
                else if (arr[i] > second && arr[i] != first)
                {
                    second = arr[i];
                }
            }

            Console.WriteLine("The second largest number is " + second);
        }

        /// <summary>
        /// Find duplicate number from an array
        /// </summary>
        public void FindDuplicateNumbersFromArray(int[] arr)
        {
            int size = arr.Length;
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < size; i++)
            {
                if (set.Add(arr[i]) == false)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }

        /// <summary>
        /// Roatates array once
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="d"></param>
        /// <param name="size"></param>
        private void LeftRotateOnce(int[] arr, int length)
        {
            int i;
            int temp = arr[0];

            for (i = 0; i < length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[i] = temp;
        }

        /// <summary>
        /// Rotate array left based on number
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="d"></param>
        /// <param name="length"></param>
        public void LeftRotate(int[] arr, int d, int length)
        {
            for (int i = 0; i < d; i++)
            {
                LeftRotateOnce(arr, length);
            }
        }

        /// <summary>
        /// Prints array 
        /// </summary>
        /// <param name="arr"></param>
        public void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        /// <summary>
        /// Find the combination of 3 numbers to match sum in array
        /// </summary>
        /// <param name="sum"></param>
        /// <param name="array"></param>
        /// <returns></returns>
        public bool FindThreeNumbersSum(int sum, int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length - 2; i++)
            {
                for (int j = i + 1; j < length - 1; j++)
                {
                    for (int k = j + 1; k < length; k++)
                    {
                        if (array[i] + array[j] + array[k] == sum)
                        {
                            Console.WriteLine("Triplet is:" + array[i] + " + " + array[j] + " + " + array[k] + " is equal to " + sum);
                            return true;
                        }
                    }

                }

            }
            return false;
        }

        /// <summary>
        /// Find if the array contains a pair for a sum
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public bool HasPairWithSum(int[] arr, int sum)
        {
            HashSet<int> compliments = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int complement = (sum - arr[i]);
                if (compliments.Contains(complement) && i != arr.Length)
                {
                    return true;
                }

                compliments.Add(complement);
            }

            return false;
        }

        public int[] mutateTheArray(int n, int[] a)
        {
            int[] b = new int[n];
            int s1 = 0, s2 = 0, s3 = 0;


            for (int i = 0; i <= n - 1; i++)
            {
                if (i - 1 < 0)
                    s1 = 0;
                else
                    s1 = a[i - 1];
                s2 = a[i];

                if (i + 1 >= n)
                    s3 = 0;
                else
                    s3 = a[i + 1];

                b[i] = s1 + s2 + s3;
            }

            return b;
        }

        public int countTinyPairs(int[] a, int[] b, int k)
        {
            int count = 0;
            for (int i = 0, j = b.Length - 1; i < a.Length; i++, j--)
            {
                int num = int.Parse(a[i].ToString() + b[j].ToString());
                if (num < k)
                    count++;
            }
            Console.Write(count);
            return count;
        }

        long hashMap(string[] queryType, int[][] query)
        {
            int[] a = new int[queryType.Length];

            foreach (var item in queryType)
            {
                if (item == "insert")
                {

                }
            }

            return 0;
        }

    }
}
