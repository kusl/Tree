using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedBlackCS;

namespace RedBlackCS.Tests
{
    /// <summary>This class contains parameterized unit tests for RedBlack</summary>
    [TestClass]
    [PexClass(typeof(RedBlack))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class RedBlackTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public RedBlack ConstructorTest()
        {
            RedBlack target = new RedBlack();
            return target;
            // TODO: add assertions to method RedBlackTest.ConstructorTest()
        }

        /// <summary>Test stub for .ctor(String)</summary>
        [PexMethod]
        public RedBlack ConstructorTest01(string strIdentifier)
        {
            RedBlack target = new RedBlack(strIdentifier);
            return target;
            // TODO: add assertions to method RedBlackTest.ConstructorTest01(String)
        }

        /// <summary>Test stub for Add(IComparable, Object)</summary>
        [PexMethod]
        public void AddTest(
            [PexAssumeUnderTest]RedBlack target,
            IComparable key,
            object data
        )
        {
            target.Add(key, data);
            // TODO: add assertions to method RedBlackTest.AddTest(RedBlack, IComparable, Object)
        }

        /// <summary>Test stub for Clear()</summary>
        [PexMethod]
        public void ClearTest([PexAssumeUnderTest]RedBlack target)
        {
            target.Clear();
            Assert.IsTrue(target.IsEmpty());
        }

        /// <summary>Test stub for Elements()</summary>
        [PexMethod]
        public RedBlackEnumerator ElementsTest([PexAssumeUnderTest]RedBlack target)
        {
            RedBlackEnumerator result = target.Elements();
            return result;
            // TODO: add assertions to method RedBlackTest.ElementsTest(RedBlack)
        }

        /// <summary>Test stub for Elements(Boolean)</summary>
        [PexMethod]
        public RedBlackEnumerator ElementsTest01([PexAssumeUnderTest]RedBlack target, bool ascending)
        {
            RedBlackEnumerator result = target.Elements(ascending);
            return result;
            // TODO: add assertions to method RedBlackTest.ElementsTest01(RedBlack, Boolean)
        }

        /// <summary>Test stub for Equals(Object)</summary>
        [PexMethod]
        public bool EqualsTest([PexAssumeUnderTest]RedBlack target, object obj)
        {
            bool result = target.Equals(obj);
            return result;
            // TODO: add assertions to method RedBlackTest.EqualsTest(RedBlack, Object)
        }

        /// <summary>Test stub for GetData(IComparable)</summary>
        [PexMethod]
        public object GetDataTest([PexAssumeUnderTest]RedBlack target, IComparable key)
        {
            object result = target.GetData(key);
            return result;
            // TODO: add assertions to method RedBlackTest.GetDataTest(RedBlack, IComparable)
        }

        /// <summary>Test stub for GetEnumerator()</summary>
        [PexMethod]
        public RedBlackEnumerator GetEnumeratorTest([PexAssumeUnderTest]RedBlack target)
        {
            RedBlackEnumerator result = target.GetEnumerator();
            return result;
            // TODO: add assertions to method RedBlackTest.GetEnumeratorTest(RedBlack)
        }

        /// <summary>Test stub for GetHashCode()</summary>
        [PexMethod]
        public int GetHashCodeTest([PexAssumeUnderTest]RedBlack target)
        {
            int result = target.GetHashCode();
            return result;
            // TODO: add assertions to method RedBlackTest.GetHashCodeTest(RedBlack)
        }

        /// <summary>Test stub for GetMaxKey()</summary>
        [PexMethod]
        public IComparable GetMaxKeyTest([PexAssumeUnderTest]RedBlack target)
        {
            IComparable result = target.GetMaxKey();
            return result;
            // TODO: add assertions to method RedBlackTest.GetMaxKeyTest(RedBlack)
        }

        /// <summary>Test stub for GetMaxValue()</summary>
        [PexMethod]
        public object GetMaxValueTest([PexAssumeUnderTest]RedBlack target)
        {
            object result = target.GetMaxValue();
            return result;
            // TODO: add assertions to method RedBlackTest.GetMaxValueTest(RedBlack)
        }

        /// <summary>Test stub for GetMinKey()</summary>
        [PexMethod]
        public IComparable GetMinKeyTest([PexAssumeUnderTest]RedBlack target)
        {
            IComparable result = target.GetMinKey();
            return result;
            // TODO: add assertions to method RedBlackTest.GetMinKeyTest(RedBlack)
        }

        /// <summary>Test stub for GetMinValue()</summary>
        [PexMethod]
        public object GetMinValueTest([PexAssumeUnderTest]RedBlack target)
        {
            object result = target.GetMinValue();
            return result;
            // TODO: add assertions to method RedBlackTest.GetMinValueTest(RedBlack)
        }

        /// <summary>Test stub for IsEmpty()</summary>
        [PexMethod]
        public bool IsEmptyTest([PexAssumeUnderTest]RedBlack target)
        {
            bool result = target.IsEmpty();
            return result;
            // TODO: add assertions to method RedBlackTest.IsEmptyTest(RedBlack)
        }

        /// <summary>Test stub for Keys()</summary>
        [PexMethod]
        public RedBlackEnumerator KeysTest([PexAssumeUnderTest]RedBlack target)
        {
            RedBlackEnumerator result = target.Keys();
            return result;
            // TODO: add assertions to method RedBlackTest.KeysTest(RedBlack)
        }

        /// <summary>Test stub for Keys(Boolean)</summary>
        [PexMethod]
        public RedBlackEnumerator KeysTest01([PexAssumeUnderTest]RedBlack target, bool ascending)
        {
            RedBlackEnumerator result = target.Keys(ascending);
            return result;
            // TODO: add assertions to method RedBlackTest.KeysTest01(RedBlack, Boolean)
        }

        /// <summary>Test stub for Remove(IComparable)</summary>
        [PexMethod]
        public void RemoveTest([PexAssumeUnderTest]RedBlack target, IComparable key)
        {
            target.Remove(key);
            // TODO: add assertions to method RedBlackTest.RemoveTest(RedBlack, IComparable)
        }

        /// <summary>Test stub for RemoveMax()</summary>
        [PexMethod]
        public void RemoveMaxTest([PexAssumeUnderTest]RedBlack target)
        {
            target.RemoveMax();
            // TODO: add assertions to method RedBlackTest.RemoveMaxTest(RedBlack)
        }

        /// <summary>Test stub for RemoveMin()</summary>
        [PexMethod]
        public void RemoveMinTest([PexAssumeUnderTest]RedBlack target)
        {
            target.RemoveMin();
            // TODO: add assertions to method RedBlackTest.RemoveMinTest(RedBlack)
        }

        /// <summary>Test stub for RotateLeft(RedBlackNode)</summary>
        [PexMethod]
        public void RotateLeftTest([PexAssumeUnderTest]RedBlack target, RedBlackNode x)
        {
            target.RotateLeft(x);
            // TODO: add assertions to method RedBlackTest.RotateLeftTest(RedBlack, RedBlackNode)
        }

        /// <summary>Test stub for RotateRight(RedBlackNode)</summary>
        [PexMethod]
        public void RotateRightTest([PexAssumeUnderTest]RedBlack target, RedBlackNode x)
        {
            target.RotateRight(x);
            // TODO: add assertions to method RedBlackTest.RotateRightTest(RedBlack, RedBlackNode)
        }

        /// <summary>Test stub for Size()</summary>
        [PexMethod]
        public int SizeTest([PexAssumeUnderTest]RedBlack target)
        {
            int result = target.Size();
            return result;
            // TODO: add assertions to method RedBlackTest.SizeTest(RedBlack)
        }

        /// <summary>Test stub for ToString()</summary>
        [PexMethod]
        public string ToStringTest([PexAssumeUnderTest]RedBlack target)
        {
            string result = target.ToString();
            return result;
            // TODO: add assertions to method RedBlackTest.ToStringTest(RedBlack)
        }

        /// <summary>Test stub for Values()</summary>
        [PexMethod]
        public RedBlackEnumerator ValuesTest([PexAssumeUnderTest]RedBlack target)
        {
            RedBlackEnumerator result = target.Values();
            return result;
            // TODO: add assertions to method RedBlackTest.ValuesTest(RedBlack)
        }
    }
}
