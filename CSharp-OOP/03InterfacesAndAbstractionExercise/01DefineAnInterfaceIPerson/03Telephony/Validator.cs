using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03Telephony
{
    public static class Validator
    {
        public static void ThrowIfNumberIsInvalid(string number)
        {
            if (number.Any(x => !char.IsDigit(x)))
            {
                throw new InvalidOperationException("Invalid number!");
            }
        }

        public static void ThrowIfURLIsInvalid(string url)
        {
            if (url.Any(x => char.IsDigit(x)))
            {
                throw new InvalidOperationException("Invalid URL!");
            }
        }
    }
}
