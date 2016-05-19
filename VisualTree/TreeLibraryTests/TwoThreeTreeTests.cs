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
    }
}
