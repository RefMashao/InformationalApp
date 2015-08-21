using System;
using System.Collections.Generic;
using System.Text;

namespace InformationalApp.Classes
{
    class InstitutionsModel
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
        public string institution = string.Empty;

        public string Institution
        {
            get { return institution; }
            set 
            {
                if (institution == value)
                {
                    return;
                }
                institution = value; 
            }

        }

    }
}
