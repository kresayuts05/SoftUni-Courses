﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _07MilitaryElite
{
    public interface ISoldier
    {
        int ID { get; }

        string FirstName { get; }

        string LastName { get; }
    }
}
