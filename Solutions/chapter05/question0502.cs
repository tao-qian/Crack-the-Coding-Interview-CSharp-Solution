using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter05
{
    class question0502
    {
        static void NotMain(String[] args)
        {
            Console.WriteLine(PrintBinary(0.75));
            Console.Read();
        }

        static String PrintBinary(double num)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(".");

            while (num > 0)
            {

                if (builder.Length >= 32)
                    return "ERROR";

                num *= 2;
                if (num >= 1)
                {
                    builder.Append("1");
                    num -= 1;
                }
                else
                    builder.Append("0");
            }
            return builder.ToString();
        }
    }
}
