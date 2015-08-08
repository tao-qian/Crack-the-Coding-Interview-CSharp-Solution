using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter17
{
    class question1706
    {

        public static void NotMain(String[] args)
        {
            int[] result = GetResult(new int[] { 0,1,2,3,4});
            Console.WriteLine("m: " + result[0] + ",n: " + result[1]);
            Console.Read();
        }

        public static int[] GetResult(int[] a)
        {
            int roughM = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < a[i - 1])
                {
                    roughM = i - 1;
                    break;
                }
                if (i == a.Length - 1)
                    return new int[] { 0, 0 };//Already soreted
            }
            int roughN = a.Length - 1;
            for (int i = a.Length - 2; i > -1; i--)
            {
                if (a[i + 1] < a[i])
                {
                    roughN = i + 1;
                    break;
                }
            }
            int min = Int32.MaxValue;
            int max = Int32.MinValue;
            for (int i = roughM; i <= roughN; i++)
            {
                min = Math.Min(min, a[i]);
                max = Math.Max(max, a[i]);
            }
            Console.WriteLine(roughM+" "+roughN);
            int m = 0;
            for (int i = roughM ; i >= 0; i--)
            {
                if (a[i] <= min)
                {
                    m = i + 1;
                    break;
                }
            }
            int n = a.Length - 1;
            for (int i = roughN; i < a.Length; i++)
            {
                if (a[i] >= max)
                {
                    n = i - 1;
                    break;
                }
            }
            return new int[] { m, n };
        }
    }
}
