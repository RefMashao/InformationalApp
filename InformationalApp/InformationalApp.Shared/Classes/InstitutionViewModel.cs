using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml;

namespace InformationalApp.Classes
{
    class InstitutionViewModel
    {
        private InformationalApp.App app = (Application.Current as App);
        private string userName = string.Empty;
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

        private string name = string.Empty;
        public string Name
        {
            get { return name; }

            set
            {
                if (name == value)
                { return; }

                name = value;
            }
        }
        public void addInstitution(string name)
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                var insert = db.Insert(new Institution()
                {
                    Id = 0,
                    insitution = name
                });

            }
        }
        public Institution getInstitution()
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                var select = db.Query<Institution>("select * from Institution").FirstOrDefault();
                return select;
            }
        }
        public void addCourse(string name,int id)
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                var insert = db.Insert(new Courses()
                {
                    Id = 0,
                    course = name,
                    institution = id

                });

            }
        }
        public Courses getCourse()
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                var select = db.Query<Courses>("select * from Courses").FirstOrDefault();
                return select;
            }
        }

    }
}
