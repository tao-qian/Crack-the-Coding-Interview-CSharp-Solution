using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter17
{
    class question1703
    {
        public static void NotMain(String[] args)
        {
            Console.WriteLine(GetTrailingZero(19));
            Console.Read();
        }

        public static int GetTrailingZero(int n)
        {
            //Only consider five because there are definitely
            //more twos.
            int fiveCount= 0;
            while (n > 1)
            {
                n /= 5;
                fiveCount += n;
            }
            return fiveCount;
        }
    }
}
