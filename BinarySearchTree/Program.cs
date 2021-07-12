using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree");

            BinarySearchTree<int> bst = new BinarySearchTree<int>(100);

            bst.Insert(56);
            bst.Insert(30);
            bst.Display();
        }
    }
}
