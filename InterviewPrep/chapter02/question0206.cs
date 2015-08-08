using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
Given a circular linked list, implement an algorithm which returns the node at
the beginning of the loop.
DEFINITION
Circular linked list: A (corrupt) linked list in which a node's next pointer points
to an earlier node, so as to make a loop in the linked list.
EXAMPLE
Input: A ->B->C->D->E- > C [the same C as earlier]
Output: C
**/
namespace InterviewPrep.chapter02
{
    class question0206
    {
        static Node getLoopBeginning(Node head)
        {
            return new Node(0);
        }
    }
}
