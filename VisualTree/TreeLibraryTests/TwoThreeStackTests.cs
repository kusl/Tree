using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreeLibrary;

namespace TreeLibraryTests
{
    [TestClass]
    public class TwoThreeStackTests
    {
        [TestMethod]
        public void InstantiateTwoThreeStack()
        {
            TwoThreeStack stack = new TwoThreeStack(5);
            Assert.IsTrue(stack.Empty());
        }
    }
}
