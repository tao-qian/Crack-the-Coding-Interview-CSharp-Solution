using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter08
{
    class question0905
    {

        static void NotMain(String[] args)
        {
            Util.PrintArray(GetPermutation("ab"));
            Console.Read();
        }

        static List<string> GetPermutation(string original)
        {
            if (original == null)
                return null;

            List<String> perm = new List<String>();
            if (original.Length == 0)
            {
                perm.Add(" ");
                return perm;
            }

            char first = original[0];
            String remainder = original.Substring(1);
            List<String> result = GetPermutation(remainder);
            foreach (string word in result)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    String start = word.Substring(0, i);
                    String end = word.Substring(i);
                    perm.Add(start + first + end);
                }
            }
            return perm;
        }
    }
}
