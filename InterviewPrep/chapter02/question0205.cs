// --------------------------------------------------------------------------------------------------------------------
// <copyright file="question0205.cs" company="">
//   
// </copyright>
// <summary>
//   The question 0205.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

/**
You have two numbers represented by a linked list, where each node contains a
single digit. The digits are stored in reverse order, such that the Ts digit is at the
head of the list. Write a function that adds the two numbers and returns the sum
as a linked list.
EXAMPLE
Input: (7-> 1 -> 6) + (5 -> 9 -> 2).That is, 617 + 295.
Output: 2 -> 1 -> 9.That is, 912.

FOLLOW UP
Suppose the digits are stored in forward order. Repeat the above problem.
EXAMPLE
Input: (6 -> 1 -> 7) + (2 -> 9 -> 5).That is, 617 + 295.
Output: 9 -> 1 -> 2.That is, 912.
**/
namespace InterviewPrep.Chapter02
{
    using chapter02;

    /// <summary> The question 0205. </summary>
    public class Question0205
    {
        /// <summary> The add lists. </summary>
        /// <param name="n1"> The n 1. </param>
        /// <param name="n2"> The n 2. </param>
        /// <param name="carry"> The carry. </param>
        /// <returns> The <see cref="Node"/>. </returns>
        public static Node AddLists(Node n1, Node n2, bool carry)
        {
            return new Node(0);
        }

        /// <summary> The add lists reverse. </summary>
        /// <param name="n1"> The n 1. </param>
        /// <param name="n2"> The n 2. </param>
        /// <returns> The <see cref="Node"/>. </returns>
        public static Node AddListsReverse(Node n1, Node n2)
        {
            return new Node(0);
        }

        /// <summary> The add reverse recur. </summary>
        /// <param name="n1"> The n 1. </param>
        /// <param name="n2"> The n 2. </param>
        /// <returns> The <see cref="NodeWrapper"/>. </returns>
        public static NodeWrapper addReverseRecur(Node n1, Node n2)
        {
            return new NodeWrapper(0, new Node(0));
        }

        //        static Node pad(int r1, int r2, Node n1, Node n2)
        //100         { 
        //101             if (r1 <= r2) 
        //102                 return n2; 
        //103             int diff = r1 - r2; 
        //104             Node padding = new Node(0); 
        //105             Node paddingHead = padding; 
        //106             for (int i = 1; i<diff; i++) 
        //107             { 
        //108                 padding.next = new Node(0); 
        //109                 padding = padding.next; 
        //110             } 
        //111             padding.next = n2; 
        //112             return paddingHead; 
        //113         } 
        //114 

        /// <summary> The node wrapper. </summary>
        public class NodeWrapper
        {
            /// <summary> The carry. </summary>
            private int carry;

            /// <summary> The n. </summary>
            private Node n;

            /// <summary> Initializes a new instance of the <see cref="NodeWrapper"/> class. </summary>
            /// <param name="carry"> The carry. </param>
            /// <param name="n"> The n. </param>
            public NodeWrapper(int carry, Node n)
            {
                this.carry = carry;
                this.n = n;
            }
        }

    }
}
