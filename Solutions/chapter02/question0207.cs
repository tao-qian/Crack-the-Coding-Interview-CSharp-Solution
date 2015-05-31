using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter02
{
    class question0207
    {
        static void NotMain(String[] args)
        {
            Node n = Node.createLinkedList(new int[]{1,2,3,1,1});
            Console.WriteLine(isPalindrome(n));
            Console.Read();
        }

        static Boolean isPalindrome(Node n)
        {
            Node fastRunner = n;
            Node slowRunner = n;
            Stack<int> stack = new Stack<int>();
            while (fastRunner != null && fastRunner.next != null)
            {
                fastRunner = fastRunner.next.next;
                stack.Push(slowRunner.data);
                slowRunner = slowRunner.next;
            }
            if (fastRunner != null && fastRunner.next == null)//Odd number of nodes
                if (stack.Count > 0)//Check case of only one node
                    stack.Pop();

            while (stack.Count > 0)
            {
                int num = stack.Pop();
                 if (num != slowRunner.data)
                     return false;
                 slowRunner = slowRunner.next;
            }
            return true;
        }
    }
}
