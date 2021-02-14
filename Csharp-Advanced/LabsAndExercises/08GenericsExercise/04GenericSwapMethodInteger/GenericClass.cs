using System;
using System.Collections.Generic;
using System.Text;

namespace _04GenericSwapMethodInteger
{
    public class GenericClass<T>
    {
        public List<T> Swap(List<T> list, int firstIndex, int secondIndex)
        {
            T variable = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = variable;

            return list;
        }
    }
}
