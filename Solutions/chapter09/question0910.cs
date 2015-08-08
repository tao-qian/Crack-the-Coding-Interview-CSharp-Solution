using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter09
{
    class question0910
    {

        static void NotMain(String[] args)
        {
            List<int[]> boxes = new List<int[]>();
            boxes.Add(new int[] { 1, 2, 3 });
            boxes.Add(new int[] { 4, 5, 6 });
            boxes.Add(new int[] { 5, 7, 10 });
            boxes.Add(new int[] { 5, 6, 7 });
            boxes.Add(new int[] { 6, 8, 9 });
            Util.PrintArray(StackBoxes(boxes));
            Console.Read();
        }

        static List<int> StackBoxes(List<int[]> original)
        {
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
            int max = -1;
            int bottomBox = -1;
            for (int i = 0; i < original.Count; i++)
            {
                int current = GetMax(i, map,original);
                if (current > max)
                {
                    max = current;
                    bottomBox = i;
                }
            }
            //Print map for debugging
            Console.WriteLine("Debugging info start: ");
            foreach (int key in map.Keys)
            {
                Console.Write(key + " -> ");
                List<int> l = map[key];
                for (int i = 0; i < l.Count; i++)
                    Console.Write(l.ElementAt(i) + " ");
                Console.WriteLine();
            }
            Console.WriteLine("Debugging info end.");
            //End printing map.
            if (bottomBox != -1)
                return map[bottomBox];
            else
                return null;
        }

        static int GetMax(int bottomBox, Dictionary<int, List<int>> map, List<int[]> original)
        {
            if (map.ContainsKey(bottomBox))
                return map[bottomBox].Count;
            int[] box1 = original.ElementAt(bottomBox);
            int secondBottomBox = -1;
            int max = -1;
            for (int i = 0; i < original.Count; i++)
            {
                if (i == bottomBox)
                    continue;
                int[] box2 = original.ElementAt(i);
                if (!(box1[0] > box2[0] && box1[1] > box2[1] && box1[2] > box2[2]))
                    continue;
                int lastStack = GetMax(i, map, original);
                if (lastStack > max)
                {
                    secondBottomBox = i;
                    max = lastStack;
                }
            }
            List<int> stack = new List<int>();
            if (secondBottomBox != -1)
            {
                stack = new List<int>(map[secondBottomBox]);
            }
            stack.Add(bottomBox);
            map.Add(bottomBox, stack);
            return stack.Count;
        }
    }
}
