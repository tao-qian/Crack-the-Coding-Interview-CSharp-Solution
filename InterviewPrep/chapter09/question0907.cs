using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter08
{
    class question0907
    {
        static void fillColor(int[,] map, int x, int y, int originalColor, int color)
        {
            if (x < 0 || y < 0 || x >= map.GetLength(0) || y >= map.GetLength(1))
                return;
            if (map[x, y] != originalColor)
                return;
            map[x, y] = color;
            fillColor(map, x + 1, y, originalColor, color);
            fillColor(map, x + 1, y + 1, originalColor, color);
            fillColor(map, x - 1, y, originalColor, color);
            fillColor(map, x - 1, y - 1, originalColor, color);
            return;
        }
    }
}
