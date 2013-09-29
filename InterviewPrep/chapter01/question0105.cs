using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter01
{
    class question0105
    {
        static void NotMain(String[] args)
        {
            Console.WriteLine(Compress("aabcccccaaa"));
            Console.Read();
        }

        static String Compress(String s)
        {
            char[] a = s.ToCharArray();
            StringBuilder sb = new StringBuilder();
            int repeatCount = 1;
            int pointer = 0;
            while (pointer < a.Length - 1)
            {
                if (a[pointer] == a[pointer + 1])
                {
                    repeatCount++;
                }
                else
                {
                    sb.Append(a[pointer]);
                    sb.Append(repeatCount);
                    repeatCount = 1;
                }
                pointer++;
            }
            sb.Append(a[pointer]);
            sb.Append(repeatCount);
            if (sb.Length > s.Length)
                return s;
            return sb.ToString();
        }
    }
}
