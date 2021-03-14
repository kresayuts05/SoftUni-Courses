using System;
using System.Collections.Generic;
using System.Text;

namespace _04BorderControl
{
    public interface IBuyer
    {
        int Food { get; }

        int BuyFood();
    }
}
