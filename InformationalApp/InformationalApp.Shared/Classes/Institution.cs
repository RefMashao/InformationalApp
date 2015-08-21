using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace InformationalApp
{
    class Institution
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string insitution { get; set; }

        
    }
}
