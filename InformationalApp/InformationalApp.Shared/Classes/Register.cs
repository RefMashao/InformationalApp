using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace InformationalApp.Classes
{
    class Register
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string name { get; set; }

        public string surname { get; set; }
      
        public string idNumber { get; set; }
       
        public string contacts { get; set; }
        public string address { get; set; }

        public string province { get; set; }
        public string email { get; set; }

        public string password { get; set; }
    }
}
