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
    }
}
