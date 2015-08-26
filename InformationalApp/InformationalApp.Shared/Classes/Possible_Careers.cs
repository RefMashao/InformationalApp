using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace InformationalApp.Classes
{
    class Possible_Careers
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string name { get; set; }
        public string course { get; set; }
    }
}
