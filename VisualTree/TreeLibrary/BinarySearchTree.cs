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
            if (Root == null)
            {
                Root = new BinarySearchTreeNode(value);
            }
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
        private BinarySearchTreeNode Search_Recursively(int value, BinarySearchTreeNode node)
        {
            if (node == null || node.Value == value)
            {
                return node;
            }
            else if (value < node.Value)
            {
                return Search_Recursively(value, node.LeftChild);
            }
            else 
            {
                return Search_Recursively(value, node.RightChild);
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
            return false;
        }
    }
}
