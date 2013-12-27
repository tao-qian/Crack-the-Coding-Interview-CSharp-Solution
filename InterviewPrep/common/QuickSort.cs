using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.common
{
    class QuickSort
    {
        public static void NotMain(String[] args)
        {
            int[] a = new int[] { 1, 3, 2, 5, 3, 2, 3, 4, 5, 3, 2 };
            int[] a2 = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                a2[i] = a[i];
            QSort(a, 0, a.Length-1);
            Array.Sort(a2);
            for (int i = 0; i < a.Length; i++)
                if (a[i] != a2[i])
                    Console.WriteLine("false");
            Console.WriteLine("Completed");
            Console.Read();
        }

        public static void QSort(int[] a, int left, int right)
        {
            int index = Parition(a, left, right);
            if (left < index - 1) 
                QSort(a, left, index - 1);
            if (index < right)
                QSort(a, index, right);
        }

        public static int Parition(int[] a,int left, int right)
        {
            int pivot = (left + right) / 2;

            while (left <= right)
            {
                while (a[left] < a[pivot])
                    left++;
                while (a[right] > a[pivot])
                    right--;
                if (left <= right)
                {
                    Swap(a, left, right);
                    left++;
                    right--;
                }
            }
            return left;
        }


        public static void Swap(int[] a, int first, int second)
        {
            int temp = a[first];
            a[first] = a[second];
            a[second] = temp;
        }

    }
}
