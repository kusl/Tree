using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeLibrary
{
    public sealed class BinarySearchTree
    {
        public BinarySearchTreeNode Root { get; set; }
        public int Count { get; private set; }
        public BinarySearchTree()
        {
            Root = null;
        }
        public bool IsEmpty()
        {
            return Root == null;
        }
        public void Add(int value)
        {
            if (IsEmpty())
            {
                Root = new BinarySearchTreeNode(value);
            }
            Count++;
        }
        private void AddRecursively()
        {

        }
        public void Remove(int value)
        {
            if (Root != null && Root.Value == value)
            {
                if (Root.LeftChild == null && Root.RightChild == null)
                {
                    Root = null;
                }
            }
        }
        public bool Contains(int value)
        {
            if(Root == null)
            {
                return false;
            }
            if (Root.Value == value)
            {
                return true;
            }
            if (SearchRecursively(Root, value).Value == value)
            {
                return true;
            }
            else { return false; }
        }
        private BinarySearchTreeNode SearchRecursively(BinarySearchTreeNode node, int value)
        {
            if (node == null || node.Value == value)
            {
                return node;
            }
            else if (value < node.Value)
            {
                return SearchRecursively(node.LeftChild, value);
            }
            else
            {
                return SearchRecursively(node.RightChild, value);
            }
        }
    }
}
