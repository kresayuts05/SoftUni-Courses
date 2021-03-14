using System;
using System.Collections.Generic;
using System.Text;

namespace _04BorderControl
{
    public interface IRobot : IIdentifiable
    {
        string Model { get; }
    }
}
