using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.common
{
    class CombinationPermutation
    {
        static void NotMain(String[] args)
        {
            List<String> test = GetPermutation("abcd");
            foreach (String s in test)
            {
                Console.WriteLine("["+s+"]");
            }
            Console.Read();
        }

        static List<String> GetCombination(String s)
        {
            List<String> newList = new List<String>();
            if (s.Length <= 1)
            {
                newList.Add(s);
                return newList;
            }
            List<String> sub = GetCombination(s.Substring(1, s.Length - 1));
            foreach (String ss in sub)
            {
                for (int i = 0; i < ss.Length + 1; i++)
                {
                    String next = ss.Substring(0, i) + s[0] + ss.Substring(i, ss.Length - i);
                    newList.Add(next);
                }
            }
            return newList;
        }

        static List<String> GetPermutation(String s)
        {
            List<String> result = new List<String>();
            if (s.Length == 0)
            {
                result.Add(s);
                return result;
            }
            List<String> last = GetPermutation(s.Substring(1, s.Length - 1));
            foreach (String ss in last)
            {
                result.Add(s[0] + ss);
                result.Add(ss);
            }
            return result;
        }
    }
}
