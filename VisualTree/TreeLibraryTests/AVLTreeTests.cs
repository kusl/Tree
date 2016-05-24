using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreeLibrary;

namespace TreeLibraryTests
{
    [TestClass]
    public class AVLTreeTests
    {
        [TestMethod]
        public void InstantiateAVLTree()
        {
            AvlTree<int,int> tree = new AvlTree<int,int>();
            int searchResult;
            tree.Insert(1, 42);
            Assert.AreEqual(true, tree.Search(1, out searchResult));
            Assert.AreEqual(42, searchResult);
        }
        [TestMethod]
        public void AddNodesToAVLTree()
        {
            AvlTree<int, int> tree = new AvlTree<int, int>();
            int searchResult;
            int size = 10;
            for (int i = 0; i < size; i++)
            {
                for (int j = size; j > 0; j--)
                {
                    tree.Insert(i, j);
                }
            }
            Assert.AreEqual(true, tree.Search(1, out searchResult));
            Assert.IsTrue(size > StepCounter.ComparisonStep);
        }
    }
}
