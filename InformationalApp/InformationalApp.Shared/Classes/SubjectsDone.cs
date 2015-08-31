using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace InformationalApp.Classes
{
    class SubjectsDone
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string course { get; set; }
        public string subjectNamed { get; set; }
    }
}
