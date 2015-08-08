using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter17
{
    class question1708
    {

        public static void NotMain(String[] args)
        {
            Console.WriteLine(MaxSubarray(new int[] { 2, -8, 3, -2, 4, -10 }));
            Console.Read();
        }

        public static int MaxSubarray(int[] a)
        {
            int maxEnding = 0;
            int max = 0;
            for (int i = 0; i < a.Length; i++)
            {
                maxEnding = Math.Max(maxEnding + a[i], 0);
                max = Math.Max(maxEnding, max);
            }
            return max;
        }
    }
}
