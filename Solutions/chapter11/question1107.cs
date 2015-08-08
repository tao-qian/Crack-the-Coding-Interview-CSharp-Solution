using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter11
{
    class question1107
    {
        static void NotMain(String[] args)
        {
            List<int[]> people = new List<int[]> ();
            people.Add(new int[] { 65,100});
            people.Add(new int[] { 70,150});
            people.Add(new int[] { 56, 90 });
            people.Add(new int[] { 75, 190 });
            people.Add(new int[] { 60, 95 });
            people.Add(new int[] { 68, 110 });
            List<int> list = StackPeople(people);
            Util.PrintArray(list);
            Console.Read();
        }

        static List<int> StackPeople(List<int[]> people)
        {
            people.OrderBy(item => item[0]);
	        List<int>[] maxList = new List<int>[people.Count];
            int max = 0;
            int bottomPerson = -1;
            for (int i = 0; i < maxList.Length; i++)
            {
                int current = GetMax(maxList, i, people);
                if (current > max)
                {
                    max = current;
                    bottomPerson = i;
                }
            }
            return maxList[bottomPerson];
        }

        static int GetMax(List<int>[] maxList, int bottomPerson, List<int[]> people)
        {
            if (maxList[bottomPerson] != null)
                return maxList[bottomPerson].Count;
            int max = -1;
            int nextPerson = -1;
            for (int i = 0; i < people.Count; i++)
            {
                if (i == bottomPerson)
                    continue;
                if (people.ElementAt(bottomPerson)[1] <= people.ElementAt(i)[1])
                    continue;
                int current = GetMax(maxList, i, people);
                if (current > max)
                {
                    max = current;
                    nextPerson = i;
                }
            }
            List<int> seq = new List<int>();
            if (nextPerson != -1)
                seq = new List<int>(maxList[nextPerson]);
            seq.Add(bottomPerson);
            maxList[bottomPerson] = seq;
            return seq.Count;
         }
    }
}
