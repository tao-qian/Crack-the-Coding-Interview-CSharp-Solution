using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter04
{
    class question0402
    {
        public static bool ContainsPath(List<int>[] adjList, int first, int second)
        {
            Queue<int> unvisited = new Queue<int>();
            int[] visited = new int[adjList.Length];
            for (int i = 0; i < visited.Length; i++)
                visited[i] = 0;
            unvisited.Enqueue(first);
            while (unvisited.Count > 0)
            {
                int current = unvisited.Dequeue();
                if (visited[current]==1)
                    continue;
                List<int> paths = adjList[current];
                foreach (int i in paths)
                {
                    if (i == second)
                        return true;
                    if (visited[i] == 0)
                        unvisited.Enqueue(i);
                }
                visited[current] = 1;
            }
            return false;
        }
    }
}
