using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter11
{
    class question1105
    {
        static int FindString(String[] a, String s, int first, int last)
        {
            int mid = (first + last) / 2;
            if (a[mid] == "")
            {
                int left = mid - 1;
                int right = mid + 1;
                while (true)
                {
                    if (left < first && right > last)
                        return -1;
                    else if (right <= last && a[right] != "")
                    {
                        mid = right;
                        break;
                    }
                    else if (left >= first && a[left] != "")
                    {
                        mid = left;
                        break;
                    }
                    right++;
                    left--;
                }
            }

            if (a[mid] == s)
                return mid;
            else if (a[mid].CompareTo(s) < 0)
                return FindString(a, s, mid + 1, last);
            else
                return FindString(a, s, first, mid - 1);
        }
    }
}
