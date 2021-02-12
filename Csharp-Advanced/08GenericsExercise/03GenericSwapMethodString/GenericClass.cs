using System;
using System.Collections.Generic;
using System.Text;

namespace _03GenericSwapMethodString
{
    public class GenericClass<T>
    {
        // List<T> list = new List<T>();

        public List<T> Swap(List<T> list, int firstIndex, int secondIndex)
        {
            T variable = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = variable;

            return list;
        }

        //public string Print(T value)
        //{
        //    Type valueName = value.GetType();

        //    return $"{valueName}: {value}";
        //}
    }
}
