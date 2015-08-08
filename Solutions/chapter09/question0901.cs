using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter08
{
    class question0801
    {
        static int countPossibility(int n)
        {
            int[] possibilities = new int[n];
            possibilities[0] = 1;
            possibilities[1] = 1;
            possibilities[2] = 2;
            for (int i = 3; i < possibilities.Length; i++)
            {
                possibilities[i] = possibilities[i - 3] + possibilities[i - 2] + possibilities[i - 1];
            }
            return possibilities[n - 1];
        }
    }
}
