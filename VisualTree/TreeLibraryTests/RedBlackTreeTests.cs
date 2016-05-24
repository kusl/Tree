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
    }
}
