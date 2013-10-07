using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    public class Util
    {
        public static void Print2DArray(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                    Console.Write((a[i][j]) + " ");
                Console.WriteLine();
            }
        }

        public static void Print2DArray(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    Console.Write((a[i,j]) + " ");
                Console.WriteLine();
            }
        }

        public static void PrintArray(List<String> a)
        {
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a.ElementAt(i));
            }
        }

        public static void PrintSet(HashSet<int> s)
        {
            Console.Write("{ ");
            foreach(int i in s)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("}");
        }
    }
}
