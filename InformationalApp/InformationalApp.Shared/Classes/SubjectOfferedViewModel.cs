using System;
using System.Collections.Generic;
using System.Text;

namespace InformationalApp.Classes
{
    class SubjectOfferedViewModel
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
        private string subjectName = string.Empty;
        public string SubjectName
        {
            get { return subjectName; }

            set
            {
                if (subjectName == value)
                { return; }

                subjectName = value;
            }
        }
        private string code = string.Empty;
        public string Code
        {
            get { return code; }

            set
            {
                if (code == value)
                { return; }

                code = value;
            }
        }
        private string price = string.Empty;
        public string Price
        {
            get { return price; }

            set
            {
                if (price == value)
                { return; }

                price = value;
            }
        }

    }
}
