using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter01
{
    class question0101
    {
        static void NotMain(string[] args)
        {
            Console.WriteLine(HasUniqueCharactersSpaceEfficient("haha"));
            Console.WriteLine(HasUniqueCharactersSpaceEfficient("helo wd"));

            Console.Read();
        }

        static bool HasUniqueCharacters(String s)
        {
            if (s.Length > 256)
                return false;
            char[] cArray = s.ToCharArray();
            char[] count = new char[256];
            for (int i = 0; i < cArray.Length; i++)
            {
                count[cArray[i]]++;
                if (count[cArray[i]] == 2)
                    return false;
            }
            return true;
        }

        static bool HasUniqueCharactersSpaceEfficient(String s)
        {
            if (s.Length > 256)
                return false;
            char[] cArray = s.ToCharArray();
            for(int i = 0;i<cArray.Length;i++)
                for (int j = i + 1; j < cArray.Length; j++)
                    if (cArray[i] == cArray[j])
                        return false;
            return true;
        }
    }
}
