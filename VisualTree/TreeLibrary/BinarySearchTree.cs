﻿namespace TreeLibrary
{
    public sealed class BinarySearchTree
    {
        public BinarySearchTreeNode Root { get; private set; }
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
            AddRecursively(Root, value);
            Count++;
        }
        private BinarySearchTreeNode AddRecursively(BinarySearchTreeNode node, int value)
        {
            int myCompare = node.Compare(value);
            if (node.Value == value)
            {
                // do nothing 
            }
            else if (myCompare == 1)
            {
                if (node.LeftChild == null)
                {
                    return node.LeftChild = new BinarySearchTreeNode(value);
                }
                return AddRecursively(node.LeftChild, value);
            }
            else if (myCompare == -1)
            {
                if (node.RightChild == null)
                {
                    return node.RightChild = new BinarySearchTreeNode(value);
                }
                return AddRecursively(node.RightChild, value);
            }
            return null;
        }
        public void Remove(int value)
        {
            if (Root != null && Root.Value == value)
            {
                if (Root.LeftChild == null && Root.RightChild == null)
                {
                    Root = null;
                }
                else 
                {
                    BinarySearchTreeNode myNode = SearchRecursively(Root, value);
                    if (myNode != null)
                    {
                        if (myNode.LeftChild != null && myNode.RightChild == null)
                        {
                            // TODO 
                        }
                        else if (myNode.LeftChild == null && myNode.RightChild == null)
                        {
                            myNode = null;
                        }
                        else if (myNode.LeftChild == null && myNode.RightChild != null)
                        {
                            // TODO
                        }
                        else if (myNode.LeftChild != null && myNode.RightChild == null)
                        {
                            // TODO
                        }
                    } 
                   else
                    {
                        // can't delete something that doesn't exist 
                    }

                }
            }
            Count--;
        }
        public bool Contains(int value)
        {
            StepCounter.ResetStepCounter();
            return (Root != null) && SearchRecursively(Root, value).Compare(value) == 0 ? true : false;
        }
        private BinarySearchTreeNode SearchRecursively(BinarySearchTreeNode node, int value)
        {
            int myCompare = node.Compare(value);
            if (node == null || node.Value == value)
            {
                return node;
            }
            else if (myCompare == 1)
            {
                if (node.LeftChild == null)
                {
                    return node;
                }
                return SearchRecursively(node.LeftChild, value);
            }
            else if (myCompare == -1)
            {
                if (node.RightChild == null)
                {
                    return node;
                }
                return SearchRecursively(node.RightChild, value);
            }
            return null;
        }
    }
}
