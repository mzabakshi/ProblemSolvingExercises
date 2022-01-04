using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class ShiftedUp5Problems
    {
        //https://www.shiftedup.com/2015/05/07/five-programming-problems-every-software-engineer-should-be-able-to-solve-in-less-than-1-hour
        #region Problem 1
        /// <summary>
        /// Problem 1  Write three functions that compute the sum of the numbers in a given list using a for-loop, a while-loop, and recursion.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        /// 


        public int SumUsingForLoop(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        public int SumUsingWhileLoop(int[] arr)
        {
            int sum = 0;
            int count = 0;
            while (count < arr.Length)
            {
                sum += arr[count];
                count++;
            }
            return sum;
        }

        public int SumUsingRecusrion(int[] arr, int index)
        {
            if (index == arr.Length)
                return 0;
            else
                return arr[index] + SumUsingRecusrion(arr, index + 1);
        }

        #endregion

        #region Problem 2
        ///Write a function that combines two lists by alternatingly taking elements. For example: given the two lists [a, b, c] and [1, 2, 3], the function should return [a, 1, b, 2, c, 3]
        ///

        public ArrayList CombineList(ArrayList list1, ArrayList list2)
        {
            ArrayList list = new ArrayList();

            for (int i = 0; i < list1.Count; i++)
            {
                list.Add(list1[i]);
                list.Add(list2[i]);
            }
            return list;
        }

        #endregion

    }
}
