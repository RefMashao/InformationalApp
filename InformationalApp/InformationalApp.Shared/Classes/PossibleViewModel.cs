using System;
using System.Collections.Generic;
using System.Text;

namespace InformationalApp.Classes
{
    class PossibleViewModel
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
        private string name = string.Empty;
        public string Name
        {
            get { return name; }

            set
            {
                if (name == value)
                { return; }

                name = value;
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
    }
}
