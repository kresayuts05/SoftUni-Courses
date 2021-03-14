using System;
using System.Collections.Generic;
using System.Text;

namespace _04BorderControl
{
    public interface IPerson : IIdentifiable, IBirthable, IBuyer
    {
        string Name { get; }

        int Age { get; }
    }
}
