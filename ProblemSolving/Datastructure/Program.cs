using Datastructure.BinaryTreeProblems;
using ProblemSolving.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    class Program
    {
        static void Main(string[] args)
        {

            // printing a linkedlist
            //LinkedList linkedList = new LinkedList();
            //linkedList.Push(2);
            //linkedList.Push(1);
            //linkedList.Append(3);
            //linkedList.Append(4);
            //linkedList.Append(5);

            //linkedList.PrintList();
            //Console.WriteLine();


            //printing binary tree in preordered list 
            //BinaryTree bt = new BinaryTree();
            //TreeNode root = new TreeNode(1);
            //root.right = new TreeNode(2);
            //root.right.left = new TreeNode(3);
            //bt.PreorderTraversal(root);

            Program p = new Program();
            //Console.WriteLine("Same number:");
            //Console.WriteLine(p.sameNumberOfFactors(-6, 21));
            //Console.WriteLine(p.sameNumberOfFactors(6, 21));
            //Console.WriteLine(p.sameNumberOfFactors(8, 12));
            //Console.WriteLine(p.sameNumberOfFactors(23, 97));
            //Console.WriteLine(p.sameNumberOfFactors(0, 1));
            //Console.WriteLine(p.sameNumberOfFactors(0, 0));

            //Console.WriteLine(p.isMercurial(new int[] { 1, 2, 10, 3, 15, 1, 2, 2 }));
            //Console.WriteLine(p.isMercurial(new int[] { 5, 2, 10, 3, 15, 1, 2, 2 }));
            //Console.WriteLine(p.isMercurial(new int[] { 1, 2, 10, 3, 15, 16, 2, 2 }));
            //Console.WriteLine(p.isMercurial(new int[] { 3, 2, 18, 1, 0, 3, -11, 1, 3 }));
            //Console.WriteLine(p.isMercurial(new int[] { 2, 3, 1, 1, 18 }));
            //Console.WriteLine(p.isMercurial(new int[] { 8, 2, 1, 1, 18, 3, 5 }));
            //Console.WriteLine(p.isMercurial(new int[] { 3, 3, 3, 3, 3, 3 }));
            //Console.WriteLine(p.isMercurial(new int[] { 1 }));
            //Console.WriteLine(p.isMercurial(new int[] { }));

            //Console.WriteLine(p.isOlympic(new int[]{ 3, 2, 1}));
            //Console.WriteLine(p.isOlympic(new int[] { 2, 2, 1, 1 }));
            //Console.WriteLine(p.isOlympic(new int[] { 1, 1000, 100, 10000, 2 }));
            //Console.WriteLine(p.isOlympic(new int[] { 1, 2, 1, 3, 2 }));
            //Console.WriteLine(p.isOlympic(new int[] { 1, 2, -1, 2, 2 }));


            Console.ReadLine();
        }



        public int sameNumberOfFactors(int n1, int n2)
        {
            if (n1 < 0 || n2 < 0)
                return -1;

            if (n1 == n2)
                return 1;

            int count1 = 0;
            int count2 = 0;

            for (int i = 1; i <= n1; i++)
            {
                if (n1 % i == 0)
                    count1++;
            }

            for (int j = 1; j <= n2; j++)
            {
                if (n2 % j == 0)
                    count2++;
            }

            if (count1 == count2) return 1;
            return 0;
        }

        public int isMercurial(int[] a)
        {
            int isMercurial = 1;

            int first = -1, second = -1, third = -1;

            for (int i = 0; i < a.Length && isMercurial == 1; i++)
            {
                int current = a[i];
                if (current == 1)
                {
                    if (third == -1)
                    {
                        first = i;
                    }
                    else
                    {
                        if (third != -1)
                        {
                            second = i;
                            if (third != -1 && first != -1 && second != -1)
                            {
                                if (first < third && third < second)
                                {
                                    isMercurial = 0;
                                }
                            }
                        }
                    }
                }
                else if (current == 3)
                    if (first != -1)
                        third = i;
            }

            if (third != -1 && first != -1 && second != -1)
            {
                if (first < third && third < second)
                {
                    isMercurial = 0;
                }
            }

            return isMercurial;
        }

        public bool isOlympic(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int sum = 0;

                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] < a[i])
                        sum += a[j];
                }

                if (a[i] < sum)
                    return false;
            }

            return true;
        }

    }
}
