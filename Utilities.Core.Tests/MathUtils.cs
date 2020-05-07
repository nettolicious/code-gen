﻿/* See the LICENSE.txt file in the root folder for license details. */

using System;
using System.Collections.Generic;
using System.Linq;

using NUnit.Framework;

namespace Utilities.Core.UnitTests
{
  [TestFixture]
  public class MathUtilsTests
  {
    [Test]
    public void IsIntegerTest()
    {
      Assert.IsFalse("".IsInteger());
      Assert.IsFalse("a".IsInteger());

      Assert.IsTrue("1".IsInteger());
      Assert.IsFalse("1.0".IsInteger());

      Assert.IsTrue("922337203685477580799".IsInteger());  // A number larger than Int64.MaxValue.
      Assert.IsTrue("-922337203685477580899".IsInteger()); // A number smaller than Int64.MinValue.
    }

    [Test]
    public void IsDoubleTest()
    {
      Assert.IsFalse("".IsDouble());
      Assert.IsFalse("a".IsDouble());

      Assert.IsTrue("1".IsDouble());
      Assert.IsTrue("1.0".IsDouble());

      /* From the MSDN entry on System.Double.Parse (http://msdn.microsoft.com/en-us/library/7yd1h1be.aspx):
      
           "... attempting to parse the string representation of either MinValue or MaxValue throws an OverflowException ..." */
      Assert.IsFalse("1.797693135e+308".IsDouble());  // Double.MaxValue.
      Assert.IsFalse("-1.797693135e+308".IsDouble()); // Double.MinValue.

      Assert.IsTrue("1.797693135e+307".IsDouble());  // Double.MaxValue / 10.
      Assert.IsTrue("-1.797693135e+307".IsDouble()); // Double.MinValue / 10.
    }

    [Test]
    public void ToBaseTest()
    {
      Assert.AreEqual("1", 1.ToBase(16));

      Assert.AreEqual("1010", 10.ToBase(2));
      Assert.AreEqual("12", 10.ToBase(8));
      Assert.AreEqual("A", 10.ToBase(16));
    }

    [Test]
    public void FromBaseTest()
    {
      Assert.AreEqual(1, "1".FromBase(2));

      Assert.AreEqual(2, "10".FromBase(2));
      Assert.AreEqual(10, "1010".FromBase(2));

      Assert.AreEqual(10, "12".FromBase(8));
      Assert.AreEqual(10, "A".FromBase(16));
    }

    [Test]
    public void SwapTest()
    {
      const Int32 V1 = 42;
      const Int32 V2 = 138;

      var v1 = V1;
      var v2 = V2;
      MathUtils.Swap(ref v1, ref v2);
      Assert.IsTrue((v1 == V2) && (v2 == V1));
    }

    [Test]
    public void IsInRangeTest()
    {
      const Int32 LOW = 5;
      const Int32 HIGH = 9;
      const Int32 IN_RANGE = 7;
      const Int32 OUT_OF_RANGE_LOW = 1;
      const Int32 OUT_OF_RANGE_HIGH = 10;

      Assert.IsTrue(IN_RANGE.IsInRange(LOW, HIGH));

      Assert.IsFalse(OUT_OF_RANGE_LOW.IsInRange(LOW, HIGH));
      Assert.IsFalse(OUT_OF_RANGE_HIGH.IsInRange(LOW, HIGH));

      Assert.IsTrue(LOW.IsInRange(LOW, HIGH, RangeCheck.Inclusive));
      Assert.IsFalse(LOW.IsInRange(LOW, HIGH, RangeCheck.Exclusive));

      Assert.IsTrue(HIGH.IsInRange(LOW, HIGH, RangeCheck.Inclusive));
      Assert.IsFalse(HIGH.IsInRange(LOW, HIGH, RangeCheck.Exclusive));
    }
  }
}
