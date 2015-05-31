using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter17
{
    class question1712
    {
        public static void GetAllPairs(int[] list,int n)
        {
            HashSet<Int32> set = new HashSet<Int32>();
            for (int i = 0; i < list.Length; i++)
                set.Add(i);
            int halfN = n/2;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] > halfN)
                {
                    int diff = n-list[i];
                    if (set.Contains(diff))
                        Console.WriteLine(diff + " " + list[i]);
                }
            }
        }
    }
}
