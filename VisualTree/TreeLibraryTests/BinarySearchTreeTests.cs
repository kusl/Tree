﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreeLibrary;

namespace TreeLibraryTests
{
    [TestClass]
    public class BinarySearchTreeTests
    {
        [TestMethod]
        public void CreateNullTree()
        {
            BinarySearchTree bst = new BinarySearchTree();
            Assert.IsNull(bst.Root);
        }
        [TestMethod]
        public void TestIsEmptyForEmptyTree()
        {
            BinarySearchTree bst = new BinarySearchTree();
            Assert.IsNull(bst.Root);
            Assert.IsTrue(bst.IsEmpty());
        }
        [TestMethod]
        public void TestIsEmptyTreeNonEmpty()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(5);
            Assert.IsFalse(bst.IsEmpty());
        }
        [TestMethod]
        public void AddNodeToNullTree()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(5);
            Assert.AreEqual(5, bst.Root.Value);
        }
        [TestMethod]
        public void RemoveRootWithNoChildren()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(5);
            bst.Remove(5);
            Assert.IsNull(bst.Root);
        }
        [TestMethod]
        public void SearchEmptyTree()
        {
            BinarySearchTree bst = new BinarySearchTree();
            Assert.IsFalse(bst.Contains(5));
        }
        [TestMethod]
        public void SearchTreeWithJustRootNode()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(5);
            Assert.IsTrue(bst.Contains(5));
        }
    }
}
