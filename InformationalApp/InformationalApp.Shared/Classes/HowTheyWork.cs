using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace InformationalApp.Classes
{
    class HowTheyWork
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string course { get; set; }
        public string howTheyWork { get; set; }
    }
}
