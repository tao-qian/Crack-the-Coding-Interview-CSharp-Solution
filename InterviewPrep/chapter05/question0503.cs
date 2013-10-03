using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter05
{
    class question0503
    {

        static void NotMain(String[] args)
        {
            int n = BitUtil.ToInt("101001101");
            BitUtil.PrintNumBinary(getNext(n));
            Console.Read();
        }

        static int getNext(int n)
        {
            int copy = n;
            int trailingZeroCount = 0;
            while ((copy & 1) != 1)
            {
                trailingZeroCount++;
                copy >>= 1;
            }
            int oneCount = 0;
            while ((copy & 1) != 0)
            {
                oneCount++;
                copy >>= 1;
            }
            copy++;
            copy = copy << (trailingZeroCount + oneCount);
            copy |= (1 << (oneCount - 1)) - 1;
            return copy;
        }
    }
}
