using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.common
{
    class MaxSubarray
    {
        public static int MaxSubArray(int[] a)
        {
            int max = 0;
            int maxEnding = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int currentEnding = maxEnding + a[i];
                maxEnding = Math.Max(0, currentEnding);
                max = Math.Max(maxEnding, max);
            }
            return max;
        }
    }
}
