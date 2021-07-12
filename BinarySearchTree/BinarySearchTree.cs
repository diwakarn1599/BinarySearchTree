using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinarySearchTree<T> where T:IComparable<T>
    {
        public T data { get; set; }
        public BinarySearchTree<T> leftTree { get; set; }
        public BinarySearchTree<T> rightTree { get; set; }
        //constructor for initializing nodes
        public BinarySearchTree(T data)
        {
            this.data = data;
            this.leftTree = null;
            this.rightTree = null;
        }
        int leftCount = 0, rightCount = 0;
        bool res;

        //methid to insert element into bst
        public void Insert(T item)
        {
            T currentNodeValue = this.data;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                {
                    leftCount++;
                    this.leftTree = new BinarySearchTree<T>(item);
                }
                else
                {
                    leftCount++;
                    this.leftTree.Insert(item);
                }
            }
            else
            {
                if (this.rightTree == null)
                {
                    rightCount++;
                    this.rightTree = new BinarySearchTree<T>(item);
                }
                else
                {
                    rightCount++;
                    this.rightTree.Insert(item);
                }
            }
        }

        //display elements 
        public void Display()
        {
            if (this.leftTree != null)
            {
                
                this.leftTree.Display();
            }
            Console.WriteLine(this.data.ToString());
            if (this.rightTree != null)
            {
                
                this.rightTree.Display();
            }
        }

        //get size of bst
        public void GetSize()
        {
            Console.WriteLine($"Size = {this.leftCount+this.rightCount+1}");
        }

        //search element in bst
        public bool SearchBst(BinarySearchTree<T> node, T val)
        {
            if (node == null)
            {
                return false;
            }
            if (node.data.Equals(val))
            { 
                res = true;

            }
            if (val.CompareTo(node.data) < 0)
            {
                SearchBst(node.leftTree,val);
            }
            if (val.CompareTo(node.data) > 0)
            {
                SearchBst(node.rightTree,val);
            }

            return res;
        }

    }
}
