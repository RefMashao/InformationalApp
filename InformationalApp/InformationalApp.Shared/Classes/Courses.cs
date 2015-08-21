using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace InformationalApp.Classes
{
    class Courses
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string course { get; set; }
        public int institution { get; set; }

    }
}
