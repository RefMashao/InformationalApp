using System;
using System.Collections.Generic;
using System.Text;

namespace InformationalApp.Classes
{
    class CoursesViewModel
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
            get { return course; }

            set
            {
                if (course == value)
                { return; }

                course = value;
            }
        }
        private int institution = 0;
        public int Institution
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
