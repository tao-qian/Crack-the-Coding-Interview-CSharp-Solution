using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter08
{
    class question0904
    {
        public static void NotMain(String[] args)
        {
            HashSet<int> original = new HashSet<int>();
            original.Add(0);
            original.Add(1);
            original.Add(2);
            original.Add(3);
            List<HashSet<int>> result = GetAllSubsets(original);
            foreach (HashSet<int> s in result)
            {
                Util.PrintSet(s);
            }
            Console.Read();
        }

        static List<HashSet<int>> GetAllSubsets(HashSet<int> s)
        {
            if (s.Count == 0)
                return null;
            s = new HashSet<int>(s);//Copy the set so the original one will not be modified.
            int element = s.ElementAt(0);
            s.Remove(element);
            List<HashSet<int>> list = GetAllSubsetsHelper(element, s);
            return list;
        }

        static List<HashSet<int>> GetAllSubsetsHelper(int n, HashSet<int> s)
        {
            List<HashSet<int>> list = new List<HashSet<int>>();
            if (s.Count == 0)
            {
                list.Add(new HashSet<int>());
                HashSet<int> withN = new HashSet<int>();
                withN.Add(n);
                list.Add(withN);
                return list;
            }
            int element = s.ElementAt(0);
            s.Remove(element);
            list = GetAllSubsetsHelper(element,s);
            List<HashSet<int>> secondList = new List<HashSet<int>>();
            for(int i = 0;i<list.Count;i++)
            {
                HashSet<int> newSet = new HashSet<int>(list.ElementAt<HashSet<int>>(i));
                newSet.Add(n);
                secondList.Add(newSet);
            }
            list.AddRange(secondList);
            return list;
        }
    }
}
