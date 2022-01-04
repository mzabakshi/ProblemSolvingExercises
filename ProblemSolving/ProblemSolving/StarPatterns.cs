using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class StarPatterns
    {
        /// <summary> 
        /// Patter 1
        ///********
        ///*******
        ///******
        ///*****
        ///****
        ///***
        ///**
        ///*
        /// </summary>
        public void Pattern1()
        {
            for (int row = 8; row >= 1; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Pattern 2
        /// *
        /// **
        /// ***
        /// ****
        /// *****
        /// ******
        /// *******
        /// ********
        /// </summary>
        public void Pattern2()
        {
            int n = 8;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }


        public void Pattern3()
        {
            Console.Write("Enter number of rows : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();




        }
    }
}
