using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreeLibrary;

namespace TreeLibraryTests
{
    [TestClass]
    public class TwoThreeTreeTests
    {
        [TestMethod]
        public void InstantiateTwoThreeTree()
        {
            TwoThreeTree tree = new TwoThreeTree(5);
            Assert.AreEqual(-1, tree.Top);
        }
        [TestMethod]
        public void TestInsertRoot()
        {
            TwoThreeTree tree = new TwoThreeTree(5);
            tree.InsertTwoThree("apple");
            Assert.AreEqual(1, tree.FindNode("cat"));
            Assert.AreEqual(1, tree.FindNode("dog"));
            Assert.AreEqual(1, tree.FindNode("egg"));
            Assert.AreEqual(-1, tree.FindNode("apple"));
        }
        [TestMethod]
        public void TestInsertMoreNodes()
        {
            TwoThreeTree tree = new TwoThreeTree(100000);
            for(int i = 0; i < 10; i++)
            {
                tree.InsertTwoThree(i.ToString());
            }
            int oldTop = tree.Top;
            int oldSize = tree.Size;
            for(int i = 100; i < 200; i++)
            {
                Assert.IsTrue(tree.FindNode(i.ToString()) > 0);
            }
            Assert.AreEqual(oldTop, tree.Top);
            Assert.AreEqual(oldSize, tree.Size);
        }
    }
}
