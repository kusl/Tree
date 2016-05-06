﻿using System;
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
        public void Add(int value)
        {
            if (Root == null)
            {
                Root = new BinarySearchTreeNode(value);
            }
        }
    }
}