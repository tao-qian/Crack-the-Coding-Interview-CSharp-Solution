using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter01
{
    class question0107
    {
        static void NotMain(String[] args)
        {
            int[][] a = new int[][] {new int[]{0,0,3},new int[]{8,0,4},new int[]{7,6,5}};
            SetZero(a);
            Util.Print2DArray(a);

            Console.Read();
        }

        static void SetZero(int[][] m)
        {
            bool[] row = new bool[m.Length];
            bool[] col = new bool[m[0].Length];
            for (int i = 0; i < m.Length; i++)
                for (int j = 0; j < m[i].Length; j++)
                    if (m[i][j] == 0)
                    {
                        row[i] = true;
                        col[j] = true;
                    }
            for (int i = 0; i < row.Length; i++)
                if (row[i])
                    for (int j = 0; j < m[i].Length; j++)
                        m[i][j] = 0;
            for (int i = 0; i < col.Length; i++)
                if (col[i])
                    for (int j = 0; j < m.Length; j++)
                        m[j][i] = 0;
        }
    }


}
