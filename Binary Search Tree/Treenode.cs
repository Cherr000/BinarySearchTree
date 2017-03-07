using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class TreeNode
    {
        public int value { get; set; }
        public TreeNode Right { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode(int value)
        {
            this.value = value;
        }
    }
}
