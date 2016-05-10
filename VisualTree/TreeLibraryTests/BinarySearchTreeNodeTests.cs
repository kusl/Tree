using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreeLibrary;

namespace TreeLibraryTests
{
    [TestClass]
    public class BinarySearchTreeNodeTests
    {
        [TestMethod]
        public void CreateNullNode()
        {
            BinarySearchTreeNode node = new BinarySearchTreeNode();
            Assert.IsNull(node.LeftChild);
            Assert.IsNull(node.RightChild);
            Assert.IsNull(node.Value);
        }
        [TestMethod]
        public void CreateNodeWithValue()
        {
            BinarySearchTreeNode node = new BinarySearchTreeNode(5);
            Assert.IsNull(node.LeftChild);
            Assert.IsNull(node.RightChild);
            Assert.AreEqual(5, node.Value);
        }
        [TestMethod]
        public void TestNodeEquals()
        {
            BinarySearchTreeNode node = new BinarySearchTreeNode(5);
            Assert.IsTrue(node.Equals(5));
        }
        [TestMethod]
        public void TestNodeDoesNotEqual()
        {
            BinarySearchTreeNode node = new BinarySearchTreeNode(5);
            Assert.IsFalse(node.Equals(2));
            Assert.IsFalse(node.Equals(-24));
        }
        [TestMethod]
        public void TestNodeIsLessThan()
        {
            BinarySearchTreeNode node = new BinarySearchTreeNode(5);
            Assert.IsTrue(node.IsLessThan(7));
            Assert.IsTrue(node.IsLessThan(99));
        }
        [TestMethod]
        public void TestNodeIsNotLessThan()
        {
            BinarySearchTreeNode node = new BinarySearchTreeNode(5);
            Assert.IsFalse(node.IsLessThan(2));
            Assert.IsFalse(node.IsLessThan(5));
        }
        [TestMethod]
        public void TestNodeIsGreaterThan()
        {
            BinarySearchTreeNode node = new BinarySearchTreeNode(5);
            Assert.IsTrue(node.IsGreaterThan(2));
            Assert.IsTrue(node.IsGreaterThan(-25));
        }
        [TestMethod]
        public void TestNodeIsNotGreaterThan()
        {
            BinarySearchTreeNode node = new BinarySearchTreeNode(5);
            Assert.IsFalse(node.IsGreaterThan(7));
            Assert.IsFalse(node.IsGreaterThan(5));
        }
    }
}
