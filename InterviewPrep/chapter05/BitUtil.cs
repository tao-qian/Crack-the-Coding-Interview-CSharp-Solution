using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter05
{
    class BitUtil
    {
        static void NotMain(String[] args)
        {
            int n = 1;
            Console.WriteLine(Convert.ToString(n, 2));
            Console.WriteLine(GetBit(n, 0));
            Console.Read();
        }

        public static Boolean GetBit(int num, int i)
        {
            return ((num >> i) & 1) == 1;
        }

        public static int SetBit(int num, int i)
        {
            return num | (1 << i);
        }

        public static int ClearBit(int num, int i)
        {
            return num & (~(1 << i));
        }

        public static void PrintNumBinary(int n)
        {
            Console.WriteLine(Convert.ToString(n, 2));
        }

        public static int ToInt(String s)
        {
           return Convert.ToInt32(s, 2);
        }
    }
}
