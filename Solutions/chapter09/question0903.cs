using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter08
{
    class question0903
    {
        static int BinarySearchForMIndex(int[] a, int start, int end)
        {
            if (start >= end)
                return -1;
            int middle = (start + end) / 2;
            if (middle == a[middle])
                return middle;
            if (middle > a[middle])
                return BinarySearchForMIndex(a, middle + 1, end);
            return BinarySearchForMIndex(a, start, middle - 1);
        }


        static int BinarySearchMIndexNonDistinct(int[] a, int start, int end)
        {
            if (end < start)
                return -1;
            int mid = (end + start) / 2;
            int midNum = a[mid];

            if (mid == midNum)
                return mid;

            int leftIndex = Math.Min(mid - 1, midNum);
            int left = BinarySearchMIndexNonDistinct(a, start, leftIndex);
            if (left >= 0)
                return left;
            int rightIndex = Math.Max(mid + 1, midNum);
            int right = BinarySearchMIndexNonDistinct(a, rightIndex, end);
            return right;

        }
    }
}
