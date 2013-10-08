using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter11
{
    class question1101
    {
        static void NotMain(String[] args)
        {
            int[] a = new int[] { 0, 2, 4, 6, 8, -1, -1, -1, -1, -1, -1 };
            int[] b = new int[] { 1, 3, 5, 7, 9, 11 };
            Insert(a, b, 5, 6);
            Util.PrintArray(a);
            Console.Read();
        }

        static void Insert(int[] a, int[] b, int aSize, int bSize)
        {
            int lastB = bSize - 1;
            int lastA = aSize - 1;
            int lastFinal = aSize + bSize - 1;
            while (lastB != -1)
            {
                while (a[lastA] > b[lastB])
                {
                    a[lastFinal] = a[lastA];
                    lastFinal--;
                    lastA--;
                }
                a[lastFinal] = b[lastB];
                lastFinal--;
                lastB--;
            }
        }
    }
}
