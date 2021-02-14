using System;
using System.Collections.Generic;
using System.Text;

namespace _05GenericCountMethodString
{
    public class Box<T>
        where T: IComparable
    {
        public Box(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
    }
}
