using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter17
{
    class question1701
    {
        public static void NotMain(String[] args)
        {
            SwapWithBit(1, 2);
            Console.Read();
        }

        public static void Swap(int a, int b)
        {
            a = a - b;
            b = a + b;
            a = b - a;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }

        public static void SwapWithBit(int a, int b)
        {
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}
