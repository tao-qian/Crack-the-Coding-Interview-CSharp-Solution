using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter01
{
    class question0106
    {

        static void NotMain(String[] args)
        {
            int[][] image = new int[][] {new int[]{1,2,3},new int[]{8,-1,4},new int[]{7,6,5}};
            RotateImage(image);
            Util.Print2DArray(image);

            Console.Read();

        }

        static int[][] RotateImage(int[][] image)
        {
            int size = image.Length;
            int start = 0;
            int end = size - 1;
            int level = 0;
            while (start < end)
            {
                for (int i = start; i < end; i++)
                {
                    int[] r1 = GetRotatedXY(i, level,size);
                    int temp = image[r1[1]][r1[0]];
                    image[r1[1]][r1[0]] = image[level][i];
                    Console.WriteLine("r1: " + r1[0]+" "+r1[1]);

                    int[] r2 = GetRotatedXY(r1[0], r1[1],size);
                    int temp2 = image[r2[1]][r2[0]];
                    image[r2[1]][r2[0]] = temp;
                    temp = temp2;

                    int[] r3 = GetRotatedXY(r2[0], r2[1],size);
                    image[level][i] = image[r3[1]][r3[0]];
                    image[r3[1]][r3[0]] = temp;
                }
                level++;
                start++;
                end--;
            }
            return image;
        }

        static int[] GetRotatedXY(int x, int y, int size)
        {
            return new int[] { size - y-1, x };
        }
    }
}
