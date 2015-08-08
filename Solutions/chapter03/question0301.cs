using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter03
{
    class question0301
    {
        //This implementation allows the stacks to have different sizes.
        //The size of each stack expands when the stack is full and there is extra space in the array.
        //Shrinking of stack size is not yet implemented.
        static void NotMain(String[] args)
        {
            MultipleStack s = new MultipleStack(3, 20);
            s.Push(10, 1);
            s.Push(111, 0);
            s.Push(11, 1);
            s.Push(1, 2);
            s.Push(2, 2);
            s.Push(12, 1);
            s.Push(13, 1);
            s.Push(3, 2);
            s.Push(14, 1);
            s.Push(15, 1);
            s.Push(16, 1);
            s.Push(17, 1);
            s.Push(18, 1);
            s.Push(4, 2);
            s.Pop(2);
            s.Push(19, 1);
            Console.WriteLine(s);

            Console.Read();
        }

        public class MultipleStack
        {
            int numOfStack;
            public int[] array;
            public SingleStack[] stacks;


            public override string ToString()
            {
                string s = "";
                for (int i = 0; i < stacks.Length; i++)
                {
                    s += stacks[i] + "\n";
                }
                return s;
            }

            public MultipleStack(int numOfStack, int totalSize)
            {
                this.numOfStack = numOfStack;
                if (totalSize < numOfStack)
                    throw new Exception("Total size is too small.");

                array = new int[totalSize];
                stacks = new SingleStack[numOfStack];

                for (int i = 0; i < numOfStack; i++)
                {
                    //initialize each stack to the size of 1.
                    stacks[i] = new SingleStack(array, i, i + 1);
                }
            }

            public int Pop(int stackIndex)
            {
                SingleStack s = stacks[stackIndex];
                return s.Pop();
                //Need to implement stack size shrinking here.
            }

            public void Push(int num, int stackIndex)
            {
                SingleStack s = stacks[stackIndex];
                if (s.Push(num))
                    return;
                int totalSize = GetTotalSize();
                if (totalSize >= array.Length)
                    throw new Exception("Array is full!");
                //Expand the current stack;
                int extension = Math.Min(s.GetSize(), array.Length - totalSize);
                Shift(s.pointer, totalSize, extension);
                //Shift bound of the arrays following the current one.
                for (int i = stackIndex + 1; i < stacks.Length; i++)
                {
                    stacks[i].start += extension;
                    stacks[i].end += extension;
                    stacks[i].pointer += extension;
                }
                s.end += extension;//Expand the current array.
                if (!s.Push(num))
                    throw new Exception("Shift operation failed...check your code.");
            }

            public void Shift(int start,int end, int count)
            {
                for (int i = end - 1; i >= start; i--)
                    array[i + count] = array[i];
            }

            public int GetTotalSize()
            {
                int total = 0;
                for (int i = 0; i < stacks.Length; i++)
                    total += stacks[i].GetSize();
                return total;
            }
        }

        public class SingleStack
        {
            public int start;
            public int end;
            public int[] array;
            public int pointer;

            public SingleStack(int[] array, int start,int end)
            {
                this.start = start;
                this.end = end;
                this.array = array;
                this.pointer = start;
            }

            public override string ToString()
            {
                String s = "";
                for (int i = start; i < pointer; i++)
                {
                    s += array[i] + " ";
                }
                for (int i = pointer; i < end; i++)
                {
                    s += "* ";
                }
                return s;
            }

            public Boolean Push(int n)
            {
                if (pointer < end)
                {
                    array[pointer] = n;
                    pointer++;
                    return true;
                }
                return false;
            }

            public int Pop()
            {
                if (pointer == start)
                    throw new Exception("Stack is empty");
                pointer--;
                return array[pointer];
            }

            public int GetSize()
            {
                return end - start;
            }

            public int GetUsedSize()
            {
                return start - pointer;
            }
        }
    }
}
