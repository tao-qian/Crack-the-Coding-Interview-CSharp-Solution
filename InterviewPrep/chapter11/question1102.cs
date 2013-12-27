using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter11
{
    class question1102
    {

        static void Main(String[] args)
        {
            String[] s = new String[] { "aaa", "bbb", "aaa", "abab", "babaa", "baba", "bbaaa", "bbaaaa", "bbb" };
            SortByAnagramsEfficient(s);
            Util.PrintArray(s);
            Console.Read();
        }

        public static void SortByAnagramsEfficient(String[] a)
        {
            Dictionary<String, LinkedList<String>> map = new Dictionary<string, LinkedList<string>>();
            for (int i = 0; i < a.Length; i++)
            {
                String anagram = getAnagram(a[i]);
                if (!map.ContainsKey(anagram))
                    map[anagram] = new LinkedList<string>();
                map[anagram].AddLast(a[i]);
            }
            int counter = 0;
            foreach(LinkedList<String> l in map.Values)
            {
                foreach (String s in l)
                {
                    a[counter] = s;
                    counter++;
                }
            }
        }

        public static String getAnagram(String s)
        {
            char[] a = s.ToCharArray();
            Array.Sort(a);
            return new String(a);
        }

        public static void SortByAnagrams(String[] a)
        {
            Array.Sort(a, new AnagramComparer());
        }

        public class AnagramComparer : Comparer<String>
        {
            public override int Compare(string x, string y)
            {
                int[] charVec = new int[26];
                for (int i = 0; i < charVec.Length; i++)
                    charVec[i] = 0;
                if (x.Length != y.Length)
                    return x.CompareTo(y);
                for (int i = 0; i < x.Length; i++)
                {
                    int c = x[i];
                    if (c >= 'a')
                        c -= 32;
                    c -= 'A';
                    charVec[c]++;
                }
                for (int i = 0; i < y.Length; i++)
                {
                    int c = y[i];
                    if (c >= 'a')
                        c -= 32;
                    c -= 'A';
                    charVec[c]--;
                    if (charVec[c] < 0)
                        return x.CompareTo(y);
                }
                return 0;
            }
        }
      
    }
}
