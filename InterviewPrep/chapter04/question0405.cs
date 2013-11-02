using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter04
{
    class question0405
    {
        public static bool IsBST(Node root)
        {
            return CheckMinMax(root, Int32.MinValue, Int32.MaxValue);
        }

        public static bool CheckMinMax(Node root, int min, int max)
        {
            if (root == null)
                return true;
            if (root.data < min || root.data > max)
                return false;
            bool checkLeft = CheckMinMax(root.left, min, root.data);
            bool checkRight = CheckMinMax(root.right, root.data, max);
            return checkLeft && checkRight;
        }
    }
}
