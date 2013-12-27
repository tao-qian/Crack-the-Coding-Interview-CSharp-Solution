using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter18
{
    class question1801
    {
        public static void NotMain(String[] args)
        {
            Console.WriteLine(Add(10, 11));
            Console.Read();
        }

        public static int Add(int a, int b)
        {
            if (b == 0)
                return a;
            int sum = a ^ b;
            int carry = (a & b) << 1;
            return Add(sum, carry);
        }
    }
}
