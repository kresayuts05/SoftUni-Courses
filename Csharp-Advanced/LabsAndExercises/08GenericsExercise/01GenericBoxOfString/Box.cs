using System;
using System.Collections.Generic;
using System.Text;

namespace _01GenericBoxOfString
{
    public class Box <T>
    {
        public Box(T value)
        {
            Value = value;
        }

        public T Value { get; set; }

        public override string ToString()
        {
            Type valueName = Value.GetType();

            return $"{valueName}: {Value}";
        }
    }
}
