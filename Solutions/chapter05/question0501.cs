using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter05
{
    class question0501
    {
        static void NotMain(string[] args)
        {
            int n = BitUtil.ToInt("100000000000");
            int m = BitUtil.ToInt("10011");
            BitUtil.PrintNumBinary(n);
            BitUtil.PrintNumBinary(m);
            BitUtil.PrintNumBinary(insert(n, m, 2, 6));
            Console.Read();
        }

        static int insert(int n, int m, int start, int end)
        {
            int mask = 1 << (end-start+1);
            mask -= 1;
            mask = mask << start;
            n = (~mask) & n;
            m = m << start;
            return m | n;
        }
    }
}
