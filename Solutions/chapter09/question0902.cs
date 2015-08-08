using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter08
{
    public enum Direction { down, right, both, impossible };

    class question0902
    {

        static void NotMain(String[] args)
        {
            bool[,] map = new bool [10,12] ;
            for(int i = 0;i<map.GetLength(0);i++)
                for(int j = 0;j<map.GetLength(1);j++)
                    map[i,j] = true;

           map[0, 9] = false;
           map[1, 8] = false;


           List<Pair> result = findPath(map);
           for (int i = 0; i < result.Count; i++)
               Console.Write(result.ElementAt<Pair>(i)+" -> ");
           Console.Read();
        }

        static List<Pair> findPath(bool[,] map)
        {
            Dir[,] dirMap = new Dir[map.GetLength(0), map.GetLength(1)];
            bool stuck = false;
            for (int i = 0; i < dirMap.GetLength(0); i++)
            {
                if (stuck)
                    dirMap[i, 0] = new Dir(0, Direction.impossible);
                else if (map[0, i])
                    dirMap[i, 0] = new Dir(1, Direction.down);
                else
                {
                    stuck = true;
                    dirMap[i, 0] = new Dir(0, Direction.impossible);
                }
            }
            stuck = false;
            for (int i = 0; i < dirMap.GetLength(1); i++)
            {
                if (stuck)
                    dirMap[0, i] = new Dir(0, Direction.impossible);
                else if (map[0, i])
                    dirMap[0, i] = new Dir(1, Direction.right);
                else
                {
                    stuck = true;
                    dirMap[0, i] = new Dir(0, Direction.impossible);
                }
            }
            //Build the map bottom up.
            for (int i = 1; i < map.GetLength(0); i++)
            {
                for (int j = 1; j < map.GetLength(1); j++)
                {
                    if (!map[i, j])
                    {
                        dirMap[i, j] = new Dir(0, Direction.impossible);
                        continue;
                    }
                    Dir up = dirMap[i - 1, j];
                    Dir left = dirMap[i, j - 1];
                    if (up.directions != Direction.impossible && left.directions != Direction.impossible)
                        dirMap[i, j] = new Dir(up.count + left.count, Direction.both);
                    else if (left.directions != Direction.impossible)
                        dirMap[i, j] = new Dir(left.count, Direction.right);
                    else if (up.directions != Direction.impossible)
                        dirMap[i, j] = new Dir(up.count, Direction.down);
                    else
                        dirMap[i, j] = new Dir(0, Direction.impossible);
                }
            }
            //Trace back.
            int possibilities = dirMap[dirMap.GetLength(0) - 1, dirMap.GetLength(1) - 1].count;
            List<Pair> path = new List<Pair>();
            int x = dirMap.GetLength(0) - 1;
            int y = dirMap.GetLength(0) - 1;
            while (x != 0 || y != 0)
            {
                path.Add(new Pair(x, y));
                Dir current = dirMap[x, y];
                if (current.directions == Direction.down)
                    x--;
                else if (current.directions == Direction.right)
                    y--;
                else if (current.directions == Direction.both)
                    x--;//It can be y-- here as well because both ways work
                else
                    return null;//Impossible to reach.
            }
            path.Reverse();
            return path;
        }
    }

    class Dir
    {
        public int count;
        public Direction directions;
        public Dir(int count, Direction directions)
        {
            this.count = count;
            this.directions = directions;
        }
    }

    class Pair
    {
        public int x;
        public int y;
        public Pair(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return "("+x + " " + y+")";
        }
    }
}
