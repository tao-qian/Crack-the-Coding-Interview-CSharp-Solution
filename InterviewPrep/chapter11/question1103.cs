using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter11
{
    class question1103
    {

        static void NotMain(String[] args)
        {
            int[] a = new int[]{50,5,20,30,40};
            Console.WriteLine(BinarySearchRotated(a,50));
            Console.Read();
        }

        static int BinarySearchRotated(int[] rotated, int n)
        {
            int rotationPoint = FindRotation(rotated);
            if (n == rotated[rotationPoint])
                return rotationPoint;
            if (n > rotated[rotationPoint]) 
            {
                int[] newA = new int[rotated.Length-rotationPoint];
                for(int i = rotationPoint;i<rotated.Length;i++)
                    newA[i-rotationPoint] = rotated[i];
                return rotationPoint+BinarySearch(newA, n);
            }
            int[] newB = new int[rotationPoint];
            for (int i = 0; i < rotationPoint; i++)
                newB[i] = rotated[i];
            return BinarySearch(newB, n);

        }

        static int BinarySearch(int[] a,int n)
        {
            int start = 0;
            int end = a.Length - 1;
            while (true)
            {
                if (start > end)
                    return -1;
                int mid = (start + end) / 2;
                if (a[mid] == n)
                    return mid;
                if (a[mid] > n)
                    end = mid - 1;
                else if (a[mid] < n)
                    start = mid + 1;
            }
            return -1;
        }

        static int FindRotation(int[] a)
        {
            int start = 0;
            int end = a.Length - 1;

            while (true)
            {
                if (start == end)
                    return start;
                int mid = (start + end) / 2;
                if (mid < a.Length && a[mid] > a[mid + 1]) 
                    return mid+1;
                if (mid > 0 && a[mid] < a[mid - 1])
                    return mid;
                if (a[start] <= a[mid])
                    start = mid + 1;
                else if (a[mid] <= a[end])
                    end = mid - 1;
            }
            return -1;
        }
    }
}
