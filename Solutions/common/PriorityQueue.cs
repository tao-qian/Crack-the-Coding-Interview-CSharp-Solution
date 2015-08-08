using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.common
{
    class PriorityQueue
    {
        static void NotMain(String[] args)
        {
            PriorityQueue q = new PriorityQueue(new int[] { 5, 6, 8, 1 });
            //q.Debug();
            Console.WriteLine(q.GetMax());
            //q.Debug();
            Console.WriteLine(q.GetMax());
            Console.WriteLine(q.GetMax());
            Console.WriteLine(q.GetMax());
            Console.Read();
        }

        int[] a;
        int heapSize;
        public PriorityQueue(int[] a)
        {
            this.a = a;
            heapSize = a.Length;
            BuildMaxHeap();
        }

        public void Debug()
        {
            for (int i = 0; i < heapSize;i++ )
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }

        public int GetMax()
        {
            if (heapSize == 0)
                throw new Exception("Queue is empty");
            int result = a[0];
            Swap(0, heapSize-1);
            heapSize--;
            MaxHeapify(0);
            return result;
        }

        private void MaxHeapify(int i)
        {
            int l = LeftChild(i);
            int r = RightChild(i);
            int max = i;
            int maxValue = a[i];
            if (l < heapSize && a[l] > maxValue)
            {
                max = l;
                maxValue = a[l];
            }
            if (r < heapSize && a[r] > maxValue)
                max = r;
            if (max != i)
            {
                Swap(max, i);
                MaxHeapify(max);
            }
        }

        private void BuildMaxHeap()
        {
            int middle = (a.Length+1)/ 2-1;
            for (int i = middle; i >= 0; i--)
                MaxHeapify(i);
        }

        private void Swap(int m, int n)
        {
            int temp = a[m];
            a[m] = a[n];
            a[n] = temp;
        }

        private static int Parent(int i)
        {
            return (i + 1) / 2 - 1;
        }

        private static int LeftChild(int i)
        {
            return 2 * i + 1;
        }

        private static int RightChild(int i)
        {
            return 2 * i + 2;
        }
    }
}
