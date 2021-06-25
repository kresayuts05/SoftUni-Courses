using System;
using System.Collections.Generic;
using System.Text;

namespace _03Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string Browing(string url)
        {
            Validator.ThrowIfURLIsInvalid(url);

            return $"Browsing: {url}!";
        }

        public string Calling(string number)
        {
            Validator.ThrowIfNumberIsInvalid(number);

            return $"Calling... {number}";
        }
    }
}
