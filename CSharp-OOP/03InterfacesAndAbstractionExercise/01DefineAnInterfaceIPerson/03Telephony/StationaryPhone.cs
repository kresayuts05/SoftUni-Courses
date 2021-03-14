using System;
using System.Collections.Generic;
using System.Text;

namespace _03Telephony
{
    public class StationaryPhone : ICallable
    {
        public string Calling(string number)
        {
            Validator.ThrowIfNumberIsInvalid(number);

            return $"Dialing... {number}";
        }
    }
}
