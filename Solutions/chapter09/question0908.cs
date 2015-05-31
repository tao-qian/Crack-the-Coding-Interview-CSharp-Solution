using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter09
{
    class question0908
    {

        static void NotMain(String[] args)
        {
            Console.WriteLine(countWays(5, 5));
            Console.Read();
        }

        static int countWays(int n, int denom)
        {
            int nextDenom = -1;
            if (n == 0)
                return 1;
            switch (denom)
            {
                case 25:
                    nextDenom = 10;
                    break;
                case 10:
                    nextDenom = 5;
                    break;
                case 5:
                    nextDenom = 1;
                    break;
                case 1:
                    return 1;//Only one way when only using 1.
            }
            int count = 0;
            for (int i = 0; i <= n / denom; i++)
            {
                count += countWays(denom * i, nextDenom);
            }
            return count;
        }
    }
}
