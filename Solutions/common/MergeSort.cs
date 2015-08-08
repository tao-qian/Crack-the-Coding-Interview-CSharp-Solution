using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.common
{
    class MergeSort
    {
        public static void NotMain(String[] args)
        {
            int[] a = new int[] { 1, 3, 2, 5, 3, 2, 3, 4, 5, 3, 2 };
            int[] a2 = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                a2[i] = a[i];
            MSort(a, 0, a.Length - 1);
            Array.Sort(a2);
            Console.WriteLine("Completed");
            Console.Read();
        }

        public static void MSort(int[] a, int low, int high)
        {
            if (low < high)
            {
                int middle = (low + high) / 2;
                MSort(a,low, middle);
                MSort(a,middle + 1, high);
                Merge(a, low,middle, high);
            }
        }

        public static void Merge(int[] a, int low, int middle, int high)
        {
            int[] helper = new int[a.Length];
            for (int i = low; i <= high; i++)
                helper[i] = a[i];

            int leftP = low;
            int rightP = middle + 1;
            int p = low;
            while (leftP <= middle && rightP <= high)
            {
                if (helper[leftP] <= helper[rightP])
                {
                    a[p] = helper[leftP];
                    leftP++;
                }
                else
                {
                    a[p] = helper[rightP];
                    rightP++;
                }
                p++;
            }


            for (int i = leftP ; i <= middle; i++, p++)
            {
                a[p] = helper[i];
            }
            
        }


    }
}
