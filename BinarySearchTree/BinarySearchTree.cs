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
        public BinarySearchTree(T data)
        {
            this.data = data;
            this.leftTree = null;
            this.rightTree = null;
        }
        int leftCount = 0, rightCount = 0;
        bool result = false;

        public void Insert(T item)
        {
            T currentNodeValue = this.data;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new BinarySearchTree<T>(item);
                }
                else
                {
                    this.leftTree.Insert(item);
                }
            }
            else
            {
                if (this.rightTree == null)
                {
                    this.rightTree = new BinarySearchTree<T>(item);
                }
                else
                {
                    this.rightTree.Insert(item);
                }
            }
        }

        public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftCount++;
                this.leftTree.Display();
            }
            Console.WriteLine(this.data.ToString());
            if (this.rightTree != null)
            {
                this.rightCount++;
                this.rightTree.Display();
            }
        }

    }
}
