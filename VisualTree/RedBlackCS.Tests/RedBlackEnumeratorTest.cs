// <copyright file="RedBlackEnumeratorTest.cs"></copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedBlackCS;

namespace RedBlackCS.Tests
{
    /// <summary>This class contains parameterized unit tests for RedBlackEnumerator</summary>
    [PexClass(typeof(RedBlackEnumerator))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class RedBlackEnumeratorTest
    {
        /// <summary>Test stub for .ctor(RedBlackNode, Boolean, Boolean)</summary>
        [PexMethod]
        public RedBlackEnumerator ConstructorTest(
            RedBlackNode tnode,
            bool keys,
            bool ascending
        )
        {
            RedBlackEnumerator target = new RedBlackEnumerator(tnode, keys, ascending);
            return target;
            // TODO: add assertions to method RedBlackEnumeratorTest.ConstructorTest(RedBlackNode, Boolean, Boolean)
        }
    }
}
