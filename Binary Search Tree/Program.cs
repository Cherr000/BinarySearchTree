using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree BST = new BinarySearchTree(16);
            BST.AddOn(07);
            BST.AddOn(25);
            BST.AddOn(95);
            BST.AddOn(11);
            BST.AddOn(08);
            BST.AddOn(11);
            BST.AddOn(09);
            BST.AddOn(01);
            BST.AddOn(95);
            BST.Find(25);
            Console.ReadKey();
        }
    }
}
