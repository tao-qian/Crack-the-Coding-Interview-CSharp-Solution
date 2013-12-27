using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.common
{
    class ReverseWords
    {

        static void NotMain(String[] args)
        {
            String s = "abc  def     zcc";
            Console.WriteLine("[]");
            Console.WriteLine("["+ReverseWord(s)+"]");
            Console.Read();
        }

        static String ReverseWord(String s)
        {

            StringBuilder result = new StringBuilder();
            s = s + " ";
            int begin = 0;
            int end = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    for (int j = end - 1; j >= begin; j--)
                    {
                        result.Append(s[j]);
                    }
                    end += 1;
                    begin = end;
                    result.Append(" ");
                }
                else
                {
                    end++;
                }
            }
            return result.ToString(0,result.Length-1);
        }
    }
}
