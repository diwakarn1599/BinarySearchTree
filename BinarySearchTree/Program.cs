using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree");

            BinarySearchTree<int> bst = new BinarySearchTree<int>(56);

            //insert element into bst
            bst.Insert(96);
            bst.Insert(30);
            bst.Insert(16);
            bst.Insert(40);
            bst.Insert(76);
            bst.Insert(90);
            bst.Insert(66);
            bst.Insert(26);
            bst.Insert(51);
            bst.Insert(3);
            bst.Insert(67);
            bst.Insert(6);
            bst.Display();
            Console.WriteLine("------------------");
            bst.GetSize();
            string res = bst.SearchBst(bst, 51) ? "Found" : "Not Found" ;
            Console.WriteLine(res) ;
        }
    }
}
