using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreeLibrary;

namespace TreeLibraryTests
{
    [TestClass]
    public class RedBlackTreeTests
    {
        [TestMethod]
        public void InstantiateRedBlackTree()
        {
            RedBlackTree tree = new RedBlackTree("apple");
            int myKey = 1;
            string myName = "Tony";
            tree.Add(myKey, myName);
            Assert.AreEqual(1, tree.Size());
        }
        [TestMethod]
        public void AddRedBlackTree()
        {
            int limit = 10000;
            RedBlackTree tree = new RedBlackTree("apple");
            for(int i = 0; i < limit; i++)
            {
                tree.Add(i, i);
            }
            Assert.AreEqual(limit, tree.Size());
        }
        [TestMethod]
        public void SearchRedBlackTree()
        {
            int limit = 10000;
            RedBlackTree tree = new RedBlackTree("apple");
            for (int i = 0; i < limit; i++)
            {
                tree.Add(i, i);
            }
            Assert.AreEqual(true, tree.Contains(2047));
            Assert.IsTrue(StepCounter.ComparisonStep == 1);
            Assert.AreEqual(true, tree.Contains(0));
            Assert.IsTrue(StepCounter.ComparisonStep > 1);
        }
    }
}
