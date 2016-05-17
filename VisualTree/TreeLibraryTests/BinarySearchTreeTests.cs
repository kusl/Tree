using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
            Assert.AreEqual(1, bst.Count);
        }
        [TestMethod]
        public void AddNodeToNonEmptyTree()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(5);
            bst.Add(12);
            Assert.AreEqual(5, bst.Root.Value);
            Assert.AreEqual(2, bst.Count);
        }
        [TestMethod]
        public void AddFiveNodesToEmptyTree()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(5);
            bst.Add(12);
            bst.Add(4);
            bst.Add(8);
            bst.Add(99);
            Assert.AreEqual(5, bst.Root.Value);
            Assert.AreEqual(5, bst.Count);
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
        [TestMethod]
        public void SearchTreeWithFiveNodes()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(5);
            bst.Add(12);
            bst.Add(4);
            bst.Add(8);
            bst.Add(99);
            Assert.IsTrue(bst.Contains(8));
            Assert.IsTrue(bst.Contains(12));
            Assert.IsTrue(bst.Contains(99));
            Assert.IsTrue(bst.Contains(5));
            Assert.IsFalse(bst.Contains(89));
            Assert.IsTrue(bst.Contains(4));
        }
        [TestMethod]
        public void SearchTreeWithNNodes()
        {
            BinarySearchTree bst = new BinarySearchTree();
            int numberOfNodes = 9999999;
            for (int i = 1; i <= numberOfNodes; i++)
            {
                Random myRandom = new Random();
                bst.Add(myRandom.Next(1, numberOfNodes));
            }
            Assert.AreEqual(numberOfNodes, bst.Count);
            Assert.IsFalse(bst.Contains(0));
            for (int i = 0; i < numberOfNodes; i++)
            {
                Assert.IsFalse(bst.Contains(numberOfNodes + i));
            }
        }
    }
}
