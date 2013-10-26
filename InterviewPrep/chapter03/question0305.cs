using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter03
{
    class question0305
    {
        public static void NotMain(String[] args)
        {
            MyQueue q = new MyQueue();
            q.Dequeue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Dequeue();
            q.Enqueue(3);
            q.Enqueue(4);
            q.Dequeue();
            q.Dequeue();
            q.Enqueue(5);
            q.Dequeue();
            q.Enqueue(6);
            q.Dequeue();
            Console.Read();
        }
    }

    public class MyQueue
    {
        Stack inStack;
        Stack outStack;

        public MyQueue()
        {
            inStack = new Stack();
            outStack = new Stack();
        }

        public void Enqueue(int n)
        {
            inStack.Push(n);
        }

        public Node Dequeue()
        {
            Node popped = outStack.Pop();
            if (popped == null)
            {
                while (inStack.top != null)
                {
                    outStack.Push(inStack.Pop());
                }
                popped = outStack.Pop();
            }
            if (popped == null)
                Console.WriteLine("null");
            else
                Console.WriteLine(popped.data);
            return popped;
        }
    }
}
