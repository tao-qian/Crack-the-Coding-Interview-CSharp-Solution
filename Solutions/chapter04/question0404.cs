using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter04
{
    class question0404
    {
        List<List<Node>> CreateLevelLinkedList(Node root)
        {
            List<List<Node>> result = new List<List<Node>>();
            Queue<Node> levelQ = new Queue<Node>();
            Queue<Node> nextQ = new Queue<Node>();
            levelQ.Enqueue(root);
            result.Add(new List<Node>());
            while (levelQ.Count > 0)
            {
                Node current = levelQ.Dequeue();
                result.Last().Add(current);
                if (current.left != null)
                    nextQ.Enqueue(current.left);
                if (current.right != null)
                    nextQ.Enqueue(current.right);
                if (levelQ.Count == 0)
                {
                    levelQ = nextQ;
                    result.Add(new List<Node>());
                }
            }
            return result;
        }
    }
}
