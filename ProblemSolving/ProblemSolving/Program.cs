using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSolving.Sorting;
using System.Collections;
using ProblemSolving.LinkedList;
using System.IO;

namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayProblems arrayObj = new ArrayProblems();
            StringProblems strObj = new StringProblems();

            //// Find the pair of element produces largest sum in the given array
            //int[] arr = { 1, 3, 5, 7, 8, 8 };
            //Console.WriteLine("The largest pair of sum");
            //Console.WriteLine(arrayObj.FindLargestPairSum(arr));

            //// Find the sequence of elements produces largest sum in the given array
            //arr = new int[] { -2, -3, 4, -1, -2, 1, 5, -3 };
            //Console.WriteLine("Maximum contiguous sum is " + arrayObj.FindLargestSumSequence(arr));

            //// Write a program to calculate max sum sub array from a given array and also give their positions
            //arr = new int[] { -2, -3, 4, -1, -2, 1, 5, -3 };
            //arrayObj.FindMaxSumSubArrayWithPositions(arr);

            //Console.WriteLine();

            // Write a function to check if the string is unique or not
            //Console.WriteLine("The string Sunny is unique: " + strObj.UniqueString("Sunny"));
            //Console.WriteLine("The string Baby is unique: " + strObj.UniqueString("baby"));
            //Console.WriteLine("The string Code is unique: " + strObj.UniqueString("Code"));
            //Console.WriteLine("The string Baby is unique: " + strObj.UniqueStringWithoutsorting("Sunny"));

            //// Write a function to find the most frequent element in an array
            //arr = new int[] { 1, 3, 5, 7, 8, 8 };
            //arrayObj.MostFrequentElementUsingLINQ(arr);

            //// Find 2nd highest number in an array
            //arr = new int[] { 1, 3, 5, 7, 8, 8 };
            //arrayObj.FindSecondHighestNumber(arr);

            ////Find duplicate numbers from an array

            //arr = new int[] { 1, 3, 5, 5, 7, 8, 8 };
            //Console.WriteLine();
            //Console.Write("Duplicate arrays are ");
            //arrayObj.FindDuplicateNumbersFromArray(arr);

            //Console.WriteLine();

            //// Is a String Palindrom
            //string str = "abba";
            //Console.WriteLine(string.Format("The string {0} is palindrom ", str) + strObj.IsPalindrom(str));
            //str = "abca";
            //Console.WriteLine(string.Format("The string {0} is palindrom ", str) + strObj.IsPalindrom(str));
            //str = "aaa";
            //Console.WriteLine(string.Format("The string {0} is palindrom ", str) + strObj.IsPalindrom(str));

            //Console.WriteLine();
            //// Rotate array
            //int d = 2;
            //int size = 7;
            //int[] arrRotate = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            //Console.Write("Arrays to be rotated ");
            //arrayObj.PrintArray(arrRotate);
            //Console.WriteLine();
            //Console.Write("Arrays after rodation " + d + " times ");
            //arrayObj.LeftRotate(arrRotate, d, size);
            //arrayObj.PrintArray(arrRotate);


            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("---------------------");

            ////Bubble sort 
            //SortingAlgorithms sort = new SortingAlgorithms();
            //arr = new int[] { 1, 6, 3, 4, 7, 2, 5 };
            //Console.Write("Before bubble sort ");
            //arrayObj.PrintArray(arr);
            //Console.WriteLine();
            //sort.BubbleSort(arr);
            //Console.Write("After bubble sort ");
            //arrayObj.PrintArray(arr);
            //Console.WriteLine();

            //Console.WriteLine();



            ////Max character occurance in string
            //string a = "cbbbbccc";
            //strObj.MostRepeatedCharacter(a);
            //Console.WriteLine();
            //strObj.MostRepatedCharacterWithoutsorting(a);
            //Console.WriteLine();

            //Console.WriteLine();



            //// BST check

            //BinaryTree tree = new BinaryTree();
            //tree.root = new Node(5);
            //tree.root.left = new Node(3);
            //tree.root.right = new Node(7);
            //tree.root.left.left = new Node(2);
            //tree.root.left.right = new Node(4);
            //tree.root.right.right = new Node(8);
            //tree.root.right.left = new Node(6);

            //if (tree.IsBST())
            //    Console.WriteLine("IS BST");
            //else
            //    Console.WriteLine("Not a BST");

            //Console.ReadLine();

            //Console.WriteLine();


            ////int[] arr3 = new int[] { 2, 6, 5, 2 };
            ////Console.WriteLine(arrayObj.FindThreeNumbersSum(8, arr3));

            ////Console.WriteLine();

            //StringProblems stringProb = new StringProblems();
            //string strRev = "My name is Zakiul";
            //stringProb.ReverseWordInString(strRev);



            //Console.WriteLine();

            //stringProb.IsAnagram("Myspace", "Spacemy");

            //Console.WriteLine();

            //if (strObj.CheckAnagram("Myspace", "Spacemy"))
            //{
            //    Console.WriteLine("Anagram");
            //}
            //else { Console.WriteLine("Not anagram"); }

            //Console.WriteLine();

            //int[] frqarray = { 1, 3, 5, 3, 1, 3 };
            //Console.WriteLine("Most frequent element: " + arrayObj.MostFrequentElementInArray(frqarray));


            //Console.WriteLine();

            BasicProblems bprobs = new BasicProblems();

            //Console.WriteLine("The factorial is: " + bprobs.FindFactorial(5));


            //Console.WriteLine();

            //bprobs.SwapNumbers(3, 4);

            //Console.WriteLine();

            //StringProblems stringProbs1 = new StringProblems();
            //if (stringProbs1.WordPattern("abba", "dog dog dog dog"))
            //{
            //    Console.WriteLine("There is a bijection");
            //}
            //else
            //    Console.WriteLine("There is no bijection");

            //Console.WriteLine();
            //int[] asum = { 1, 2, 3, 9 };
            //int[] asum1 = { 1, 2, 4, 4 };
            //int sum = 8;
            //Console.WriteLine("Is pair with sum? " + arrayObj.HasPairWithSum(asum, sum));
            //Console.WriteLine("Is pair with sum? " + arrayObj.HasPairWithSum(asum1, sum));

            //Console.WriteLine();


            ////print bracket combinations
            //int n = 2;
            //Console.WriteLine("Combinations for " + n);
            //BasicProblems bscp = new BasicProblems();
            //bscp.BracketCombinations(n);



            //Console.WriteLine();

            ////remove duplicates
            //String str = "geeksforgeeks";
            //strObj.RemoveDuplicateCharInPlace(str);

            //Console.WriteLine();

            //ShiftedUp5Problems sfProbs = new ShiftedUp5Problems();
            //int[] arrShiftUp = new int[] { 2, 4, 5, 7};

            //Console.WriteLine("For loop: " + sfProbs.SumUsingForLoop(arrShiftUp));
            //Console.WriteLine("While loop: " + sfProbs.SumUsingWhileLoop(arrShiftUp));
            //Console.WriteLine("Recursion: " + sfProbs.SumUsingRecusrion(arrShiftUp, 0));


            //Console.WriteLine();
            //ArrayList list1 = new ArrayList();
            //list1.Add('a');
            //list1.Add('b');
            //list1.Add('c');
            //ArrayList list2 = new ArrayList();
            //list2.Add(1);
            //list2.Add(2);
            //list2.Add(3);

            //ArrayList list = sfProbs.CombineList(list1, list2);

            //foreach (var item in list)
            //{
            //    Console.Write(item + ", ");
            //}

            //Console.WriteLine();


            //StarPatterns starPatterns = new StarPatterns();
            //starPatterns.Pattern1();
            //starPatterns.Pattern2();


            //LinkedListProblems lprobs = new LinkedListProblems();
            //LinkedList
            //lprobs.AddTwoNumbers();


            //arrayObj.mutateTheArray(5, new int[] { 4, 0, 1, -2, 3 });
            //arrayObj.countTinyPairs(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 }, 31);
            //Console.ReadKey();
            //Console.WriteLine(solution(123456));
            //Console.WriteLine(PatternMatch("0", "y"));


            //Console.WriteLine(bprobs.StrictlyIncreasing(new int[] { 1, 3, 2, 1 }));

            //Console.WriteLine(bprobs.solution(new string[] { "is", "valid", "right" }, "isValid"));
            //Console.WriteLine(bprobs.solution(new string[] { "is", "valid", "right" }, "IsValid"));
            //Console.WriteLine(bprobs.solution(new string[] { "a" }, "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA")); 


            CodesignalProblems codeSignal = new CodesignalProblems();

            var matrix = new int[3][] { new int[] { 0, 1, 1, 2 }, new int[] { 0, 5, 0, 0 }, new int[] { 2, 0, 3, 3 } };
            Console.WriteLine(codeSignal.CodebotsAvailableRooms(matrix));

            Console.ReadKey();
        }


    }
}
