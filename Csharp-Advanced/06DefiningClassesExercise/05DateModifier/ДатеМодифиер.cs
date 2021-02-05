using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public static class DateModifier
    {
        public static int DaysCalculator(string firstDateStr, string secondDateStr)
        {
            DateTime firstDate = DateTime.Parse(firstDateStr);
            DateTime secondDate = DateTime.Parse(secondDateStr);

            TimeSpan diff = firstDate - secondDate;

            return Math.Abs(diff.Days);
        }
    }
}
