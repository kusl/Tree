using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedBlackCS;

namespace RedBlackCS.Tests
{
    /// <summary>This class contains parameterized unit tests for RedBlackNode</summary>
    [TestClass]
    [PexClass(typeof(RedBlackNode))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class RedBlackNodeTest
    {
    }
}
