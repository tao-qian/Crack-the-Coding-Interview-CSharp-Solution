using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter03
{
    class question0303
    {
        public static void NotMain(String[] args)
        {
            SetOfStacks s = new SetOfStacks();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);
            s.Push(6);
            s.PopAt(0);
            s.PopAt(1);
            s.PopAt(1);
            s.PopAt(0);
            Console.Read();
        }
    }

    class SetOfStacks
    {
        List<Stack> stacks;
        int stackLimit = 2;

        public SetOfStacks()
        {
            stacks = new List<Stack>();
        }

        public int PopAt(int index)
        {
            if (index >= stacks.Count)
                throw new Exception("Index too big");
            int num = stacks.ElementAt(index).Pop().data;
            Shift(index);
            //PrintStacks();
            return num;
        }

        public void Shift(int index)
        {
            Stack s = stacks.ElementAt(index);
            if (s.top == null)//If it's empty, remove the stack from the list
            {
                stacks.Remove(s);
                return;
            }
            index++;
            while (index < stacks.Count)
            {
                Stack next = stacks.ElementAt(index);
                Stack current = stacks.ElementAt(index-1);
                Node n = TakeOne(next);
                current.Push(n);
                index++;
            }
            if (stacks.Last().top == null)
                stacks.Remove(stacks.Last());
        }

        public Node TakeOne(Stack s)
        {
            //Assume s has as least one element.
            Node bottom = s.top;
            
            //If there is only one element.
            if (bottom.next == null)
            {
                s.top = null;
                return bottom;
            }

            while (bottom.next.next != null)
            {
                bottom = bottom.next;
            }
            Node temp = bottom.next;
            bottom.next = null;
            return temp;
        }

        public void Push(int n)
        {
            Node node = new Node(n);
            Stack last;
            if (stacks.Count == 0)
            {
                last = new Stack();
                stacks.Add(last);
            }
            else last = stacks.ElementAt(stacks.Count - 1);
            if (last.GetSize() == stackLimit)
            {
                last = new Stack();
                stacks.Add(last);
            }
            last.Push(n);
            //PrintStacks();
        }

        public void PrintStacks()
        {
            Util.PrintArray(stacks);
            Console.WriteLine("-");
        }

    }


}
