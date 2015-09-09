using System;
using System.Collections.Generic;
using System.Text;

namespace InformationalApp.Classes
{
    class Pirate
    {
        public Pirate(string insitution)
        {
            Insitution = insitution;
        }
        public string Insitution { get; private set; }

        public string Institution
        {
            get { return string.Format("{0}", Insitution); }
        }
    }
}
