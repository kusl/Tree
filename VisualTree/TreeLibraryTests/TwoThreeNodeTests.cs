using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreeLibrary;

namespace TreeLibraryTests
{
    [TestClass]
    public class TwoThreeNodeTests
    {
        [TestMethod]
        public void InstantiateTwoThreeNode()
        {
            TwoThreeNode node = new TwoThreeNode();
            Assert.IsNull(node.LeftData);
            Assert.IsNull(node.RightData);
            Assert.AreEqual(0, node.LeftChild);
            Assert.AreEqual(0, node.MiddleChild);
            Assert.AreEqual(0, node.RightChild);
            Assert.AreEqual(0, node.LeftDataDuplicates);
            Assert.AreEqual(0, node.RightDataDuplicates);
        }
    }
}
