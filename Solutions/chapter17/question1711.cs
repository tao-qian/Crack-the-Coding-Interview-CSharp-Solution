using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter17
{
    class question1711
    {
        public static int Rand5()
        {
            Random r = new Random();
            return r.Next(5);
        }

        public static int Rand7()
        {
            int n = Rand5() * 5 + Rand5();
            if (n >= 21)
                return Rand7();
            return n % 7;
        }
    }
}
