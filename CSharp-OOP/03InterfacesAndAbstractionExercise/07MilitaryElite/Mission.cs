using System;
using System.Collections.Generic;
using System.Text;

namespace _07MilitaryElite
{
    public class Mission
    {
        public string CodeName { get; set; }

        public string State { get; set; }

        public void CompleteMission()
        {
            State = "Finished";
        }
    }
}
