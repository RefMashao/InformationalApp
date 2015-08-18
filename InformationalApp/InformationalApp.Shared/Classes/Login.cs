using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace InformationalApp.Classes
{
     [Table("Logins")]
    class Login
    {
        public string username { get; set; }

        public string password { get; set; }
    }
}
