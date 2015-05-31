using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter18
{
    class question1806
    {
        public static int Select(int[] array, int left, int right, int rank)
        {
            Random r = new Random();
            int pivot = array[r.Next(left, right + 1)];

            int leftEnd = Parition(array, left, right, pivot);

            int leftSize = leftEnd - left + 1;
            if (leftSize == rank + 1)
            {
                int max = Int32.MinValue;
                for (int i = left; i <= leftEnd; i++)
                    if (array[i] > max)
                        max = array[i];
                return max;
            }
            else if (rank < leftSize)
                return Select(array, left, leftEnd, rank);
            else
                return Select(array, leftEnd + 1, right, rank - leftSize);
        }

        public static int Parition(int[] array, int left, int right, int pivot)
        {
            while (true)
            {
                while (left <= right && array[left] <= pivot)
                    left++;
                while (left <= right && array[right] > pivot)
                    right--;
                if (left > right)
                    return left - 1;
                Swap(array, left, right);
            }
        }

        public static void Swap(int[] array, int first, int second)
        {
            int temp = array[first];
            array[first] = array[second];
            array[second]= temp;
        }
    }
}
