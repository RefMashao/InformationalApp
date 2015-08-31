using System;
using System.Collections.Generic;
using System.Text;

namespace InformationalApp.Classes
{
    class SubjectsDoneViewModel
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
         private string subjectNamed = string.Empty;
         public string SubjectNamed
        {
            get { return subjectNamed; }

            set
            {
                if (subjectNamed == value)
                { return; }

                subjectNamed = value;
            }
        }
    }
    
}
