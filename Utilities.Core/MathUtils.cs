/* See the LICENSE.txt file in the root folder for license details. */

using System;
using System.Globalization;

namespace Utilities.Core
{
  public enum RangeCheck { Exclusive, Inclusive }

  public static class MathUtils
  {
    public static Boolean IsInteger(this String number)
    {
      /* Double.TryParse is used so num values with a larger range than Int64 can be handled. */
      Double _ = 0.0;
      return Double.TryParse(number, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out _);
    }

    public static Boolean IsDouble(this String number)
    {
      Double _ = 0.0;
      return Double.TryParse(number, NumberStyles.Float, NumberFormatInfo.CurrentInfo, out _);
    }

    private static void CheckBase(Int32 _base /* "base" is a keyword in C#, hence the leading underscore. */)
    {
      if (!_base.IsInRange(2, 36))
        throw new ArgumentOutOfRangeExceptionFmt(Properties.Resources.MathUtils_BaseOutOfRange, _base);
    }

    public static String ToBase(this Int32 number, Int32 toBase)
    {
      return Convert.ToInt64(number).ToBase(toBase);
    }

    public static String ToBase(this Int64 number, Int32 toBase)
    {
      CheckBase(toBase);

      var digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".Substring(0, toBase);
      var result = "";

      while (number > 0)
      {
        var digitValue = (Int32) (number % (Double) toBase);
        number /= toBase;
        result = digits.Substring(digitValue, 1) + result;
      }

      return result;
    }

    public static Int32 FromBase(this String otherBaseNumber, Int32 fromBase)
    {
      CheckBase(fromBase);

      var digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".Substring(0, fromBase);
      var result = 0;

      otherBaseNumber = otherBaseNumber.ToUpper();

      for (Int32 i = 0; i < otherBaseNumber.Length; i++)
      {
        var digitValue = digits.IndexOf(otherBaseNumber.Substring(i, 1), 0, digits.Length);

        if (digitValue < 0)
          throw new ArgumentException(String.Format(Properties.Resources.MathUtils_BadDigit, otherBaseNumber, fromBase));

        result = (result * fromBase) + digitValue;
      }

      return result;
    }

    public static String FromBaseToBase(this String number, Int32 fromBase, Int32 toBase)
    {
      return number.FromBase(fromBase).ToBase(toBase).TrimStart("0".ToCharArray());
    }
    
    public static void Swap(ref Int32 number1, ref Int32 number2)
    {
      var temp = number1;
      number1 = number2;
      number2 = temp;
    }

    public static Boolean IsInRange(this Int32 value, Int32 min, Int32 max)
    {
      return value.IsInRange(min, max, RangeCheck.Inclusive);
    }

    public static Boolean IsInRange(this Int32 value, Int32 min, Int32 max, RangeCheck rangeCheck)
    {
      if (min > max)
        throw new ArgumentOutOfRangeExceptionFmt(Properties.Resources.MathUtils_MinGreaterThanMax, min, max);

      switch (rangeCheck)
      {
        case RangeCheck.Exclusive:
          return ((value > min) && (value < max));
        case RangeCheck.Inclusive:
          return ((value >= min) && (value <= max));
        default:
          throw new ArgumentOutOfRangeExceptionFmt(Properties.Resources.MathUtils_BadRangeCheckValue, rangeCheck);
      }
    }
  }
}
