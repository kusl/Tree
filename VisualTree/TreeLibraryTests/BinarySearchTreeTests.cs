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
    }
}
