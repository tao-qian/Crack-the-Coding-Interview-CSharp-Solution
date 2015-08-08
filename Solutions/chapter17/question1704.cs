using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter17
{
    class question1704
    {
        public static void NotMain(String[] args)
        {
            Console.WriteLine(Max(2,-3));
            Console.Read();
        }

        static int Sign(int n)
        {
            return 1^(n >> 31)&0x1;
        }

        static int Max(int a,int b)
        {
            int sa = Sign(a);
            int sb = Sign(b);
            int sd = Sign(a-b);

            int useSignOfA = sa ^ sb;

            int useSignOfD = 1^(useSignOfA);

            //if a and b are of different signs, m = sa, otherwise, m = sd
            int m = useSignOfA * sa + useSignOfD * sd;
            int n = 1 ^ m;
            return m * a + n * b;
        }
    }
}
