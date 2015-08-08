using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
Write an algorithm such that if an element in an MxN matrix is 0, its entire row
and column are set to 0.
**/

namespace InterviewPrep.Chapter01
{
    public class Question0107
    {
        public static int[][] SetZero(int[][] m)
        {
            return new[] { new[] { 2, 4, 6 }, new[] { 1, 3, 5, 7, 9 } };
        }

        public static int[,] SetZero(int[,] m)
        {
            return new[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
        }
    }
}
