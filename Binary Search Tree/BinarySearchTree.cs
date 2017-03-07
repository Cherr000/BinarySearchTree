using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class BinarySearchTree
    {
        TreeNode treeNode;
        int result;
        public BinarySearchTree(int value)
        {
            treeNode = new TreeNode(value);
        }
        public void AddOn(int value)
        {
            int result;
            TreeNode Location = new TreeNode(value);
            TreeNode newTreeNode = treeNode, top = null;
            while (newTreeNode != null)
            {
                result = newTreeNode.value.CompareTo(Location.value);
                if (result == 0)
                    return;
                else if (result > 0)
                {
                    top = newTreeNode;
                    newTreeNode = newTreeNode.Left;
                }
                else if (result < 0)
                {
                    top = newTreeNode;
                    newTreeNode = newTreeNode.Right;
                }
            }
            if (top == null)
            {
                newTreeNode = Location;
            }
            else
            {
                result = top.value.CompareTo(Location.value);
                if (result > 0)
                {
                    top.Left = Location;
                }
                else
                {
                    top.Right = Location;
                }
            }
        }
        public bool Find(int value)
        {
            TreeNode newTreeNode = treeNode;
            TreeNode Location = new TreeNode(value);
            while (newTreeNode != null)
            {
                result = newTreeNode.value.CompareTo(Location.value);
                if (result == 0)
                    return true;
                else if (result > 0)
                {
                    newTreeNode = newTreeNode.Left;
                }
                else if (result < 0)
                {
                    newTreeNode = newTreeNode.Right;
                }
            }
            return false;
        }
    }
}
