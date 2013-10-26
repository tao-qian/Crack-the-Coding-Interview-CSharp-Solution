using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter03
{
    class question0302
    {
        public static void NotMain(String[] args)
        {
            MinStack ms = new MinStack();
            Console.WriteLine(ms);
            ms.Push(5);
            Console.WriteLine(ms);
            ms.Push(6);
            Console.WriteLine(ms);
            ms.Push(3);
            Console.WriteLine(ms);
            ms.Push(7);
            Console.WriteLine(ms);
            ms.Pop();
            Console.WriteLine(ms);
            ms.Pop();
            Console.WriteLine(ms);

            Console.Read();
        }

    }

    public class MinStack : Stack
    {
        Stack mins;

        public MinStack()
        {
            mins = new Stack();
        }

        public override void Push(int n)
        {
            if (mins.top == null || mins.top.data>=n)
                mins.Push(new Node(n));
            base.Push(n);
        }

        public override void Push(Node n)
        {
            if (mins.top == null || mins.top.data >= n.data)
                mins.Push(new Node(n.data));
            base.Push(n);
        }

        public override Node Pop()
        {
            Node n = base.Pop();
            if (n == null)
                return n;
            if (mins.top.data == n.data)
                mins.Pop();
            return n;
        }

        public override string ToString()
        {
            
            return "{ " + base.ToString() + "} min: " + ((mins.top==null)?"null":""+mins.top.data);
        }
    }
}
