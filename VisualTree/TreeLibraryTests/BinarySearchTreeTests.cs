using System;
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
    }
}
