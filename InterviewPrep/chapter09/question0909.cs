using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter09
{
    class question0909
    {

        static void NotMain(String[] args)
        {
            int[] cols = new int[GRID_SIZE];
            for (int i = 0; i < cols.Length; i++)
                cols[i] = -1;
            List<int[]> results = new List<int[]>();
            placeQueens(0, cols, results);
            printQueens(results.ElementAt<int[]>(0));
            Console.Read();
        }

        static void printQueens(int[] cols)
        {
            for (int i = 0; i < cols.Length; i++)
            {
                int queenPos = cols[i];
                for (int j = 0; j < queenPos; j++)
                {
                    Console.Write("o ");
                }
                Console.Write("+ ");
                for (int j = queenPos + 1; j < GRID_SIZE; j++)
                    Console.Write("o ");
                Console.WriteLine();
            }
        }

        static int GRID_SIZE = 8;

        static void placeQueens(int row, int[] cols, List<int[]> results)
        {
            int[] temp = new int[GRID_SIZE];
            for (int i = 0; i < temp.Length; i++)
                temp[i] = cols[i];
            cols = temp;
            if (row == GRID_SIZE)
            {
                Console.WriteLine("Added");
                results.Add(cols);
                return;
            }
            for (int col = 0; col < GRID_SIZE; col++)
            {
                if (checkPossible(row, col, cols))
                {
                    cols[row] = col;
                    placeQueens(row+1, cols, results);
                }
            }
        }

        static bool checkPossible(int row1, int col1, int[] cols)
        {
            for (int row2 = 0; row2 < row1; row2++)
            {
                int col2 = cols[row2];
                if (cols[row2] == -1)
                    continue;
                if (col2 == col1)
                    return false;
                int rowDiff = row1 - row2;//Row is always greater because new rows are added later.
                int colDiff = Math.Abs(col2 - col1);
                if (rowDiff == colDiff)//Check diag
                    return false;
            }
            return true;

        }
    }
}
