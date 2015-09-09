using System;
using System.Collections.Generic;
using System.Text;

namespace InformationalApp.Classes
{
    class HowTheyWorkViewModel
    {
          private int id = 0;
        public int ID
        {
            get { return id; }
            set
            {
                if (id == value)
                {
                    return;
                }
                id = value;
            }
        }

        private string course = string.Empty;
        public string Course
        {
            get { return course; }

            set
            {
                if (course == value)
                { return; }

                course = value;
            }
        }
         private string howTheyWork = string.Empty;
         public string HowTheyWork
        {
            get { return howTheyWork; }

            set
            {
                if (howTheyWork == value)
                { return; }

                howTheyWork = value;
            }
        }
    }
    
    
}
