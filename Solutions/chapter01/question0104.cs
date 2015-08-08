using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter01
{
    class question0104
    {
        static void NotMain(String[] args)
        {
            Console.WriteLine(ReplaceSpace("Mr John Smith    "));
            Console.Read();
        }

        static String ReplaceSpace(String s)
        {
            char[] a = s.ToCharArray();
            int endPointer = a.Length - 1;
            int nonSpacePointer = a.Length - 1;
            while (a[nonSpacePointer] == ' ')
                nonSpacePointer--;
            while (endPointer != 0)
            {
                if (a[nonSpacePointer] != ' ')
                {
                    a[endPointer] = a[nonSpacePointer];
                    endPointer--;
                }
                else
                {
                    a[endPointer] = '0';
                    endPointer--;
                    a[endPointer] = '2';
                    endPointer--;
                    a[endPointer] = '%';
                    endPointer--;
                }
                nonSpacePointer--;
            }
            return new String(a);
        }
    }
}
