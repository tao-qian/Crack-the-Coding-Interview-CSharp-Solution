using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter05
{
    class question0506
    {
        static int swapOddEventBits(int x)
        {
            int a =(int)((x & 0xaaaaaaaa)>>1);
	        return a|((x&0x55555555)<<1);
        }
    }
}
