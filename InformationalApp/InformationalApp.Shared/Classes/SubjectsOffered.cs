using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace InformationalApp.Classes
{
    class SubjectsOffered
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string course { get; set; }
        public string subjectName { get; set; }
        public string code  { get; set; }
        public string price { get; set; }
    }
}
