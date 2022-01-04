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
    }
}
