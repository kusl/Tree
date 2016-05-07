using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            bool actualResult = bst.Contains(5);
            Assert.IsFalse(actualResult);
        }
        [TestMethod]
        public void SearchTreeWithJustRootNode()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(5);
            bool actualResult = bst.Contains(5);
            Assert.IsTrue(actualResult);
        }
    }
}
