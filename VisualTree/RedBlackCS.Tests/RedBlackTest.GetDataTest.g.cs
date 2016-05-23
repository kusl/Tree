using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedBlackCS;
// <copyright file="RedBlackTest.GetDataTest.g.cs"></copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace RedBlackCS.Tests
{
    public partial class RedBlackTest
    {

[TestMethod]
[PexGeneratedBy(typeof(RedBlackTest))]
[PexRaisedException(typeof(ArgumentException))]
public void GetDataTestThrowsArgumentException503()
{
    RedBlack redBlack;
    object o;
    object boxu = (object)(default(uint));
    object s0 = new object();
    redBlack = new RedBlack();
    redBlack.Add((IComparable)boxu, s0);
    o = this.GetDataTest(redBlack, (IComparable)null);
}

[TestMethod]
[PexGeneratedBy(typeof(RedBlackTest))]
public void GetDataTest928()
{
    RedBlack redBlack;
    object o;
    object boxi = (object)(default(int));
    object s0 = new object();
    redBlack = new RedBlack();
    redBlack.Add((IComparable)boxi, s0);
    o = this.GetDataTest(redBlack, (IComparable)null);
    Assert.IsNotNull((object)redBlack);
}

[TestMethod]
[PexGeneratedBy(typeof(RedBlackTest))]
public void GetDataTest92801()
{
    RedBlack redBlack;
    object o;
    object boxi = (object)(default(int));
    object s0 = new object();
    PexSafeHelpers.AssignBoxedValue<int>(boxi, 512);
    redBlack = new RedBlack();
    redBlack.Add((IComparable)boxi, s0);
    o = this.GetDataTest(redBlack, (IComparable)null);
    Assert.IsNotNull((object)redBlack);
}
    }
}
