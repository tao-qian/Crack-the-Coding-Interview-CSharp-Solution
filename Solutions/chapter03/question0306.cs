using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter03
{
    class question0306
    {
        public static void NotMain(String[] args)
        {
            Stack s = new Stack();
            s.Push(5);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            Console.WriteLine(s);
            s = Sort(s);
            Console.WriteLine(s);
            Console.Read();
        }

        public static Stack Sort(Stack s)
        {
            Stack r = new Stack();
            while (!s.IsEmpty())
            {
                Node temp = s.Pop();
                while(!r.IsEmpty() && r.Peek().data > temp.data)
                {
                    s.Push(r.Pop());
                }
                r.Push(temp);
            }
            return r;
        }
    }
}
