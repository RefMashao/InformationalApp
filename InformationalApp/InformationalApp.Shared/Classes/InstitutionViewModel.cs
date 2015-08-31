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
            get { return Userid; }
            set
            {
                if (Userid == value)
                {
                    return;
                }
                Userid = value;
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
        private string career = string.Empty;
        public string Career
        {
            get { return career; }

            set
            {
                if (career == value)
                { return; }

                career = value;
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
        public void addCareers(string career, string name)
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                var insert = db.Insert(new Possible_Careers()
                {
                    Id = 0,
                    name = career,
                    course = name

                });

            }
        }
        public Possible_Careers getCareer()
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                var select = db.Query<Possible_Careers>("select * from Possible_Careers").FirstOrDefault();
                return select;
            }
        }


        public Enroll getUser(string idNo)
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                var select = db.Query<Enroll>("select * from Enroll where idNumber='"+idNo+"'").FirstOrDefault();
                return select;
            }
        }
        public void addSubjectsOffered(string course, string subjectName,string code, string price)
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                var insert = db.Insert(new SubjectsOffered()
                {
                    Id = 0,
                    course = course,
                    subjectName = subjectName,
                    code = code,
                    price = price

                });

            }
        }
        public SubjectsOffered getSubjectsOffered()
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                var select = db.Query<SubjectsOffered>("select * from SubjectsOffered").FirstOrDefault();
                return select;
            }
        }
        public void addSubjectsDone(string course, string subjectNamed)
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                var insert = db.Insert(new SubjectsDone()
                {
                    Id = 0,
                    course = course,
                    subjectNamed = subjectNamed
                    

                });

            }
        }
        public SubjectsDone getSubjectsDone()
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                var select = db.Query<SubjectsDone>("select * from SubjectsDone").FirstOrDefault();
                return select;
            }
        }
        public void updateDetails(string name,string surname,string idNumber, string contacts,string address, string province)
        {

            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {

                var Personaldetails = db.Query<Enroll>("update Enroll set name = '" + name + "', surname = '" + surname + "',contacts = '" + contacts + "',address = '" + address + "',province = '" + province + "'  where idNumber = '" + idNumber + "' ").FirstOrDefault();
            }
        }
        public void updateLogin( string idNumber,string email, string password)
        {

            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                var updateLogin = db.Query<Enroll>("update Enroll set email ='" + email + "',password ='" + password + "' where idNumber = '" + idNumber + "'").FirstOrDefault();

            }
        }
        public Enroll getRegisteredUser(string idNo)
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                var select = db.Query<Enroll>("select * from Enroll where idNumber='" + idNo + "'").FirstOrDefault();
                return select;
                
            }
        }
        public Enroll getRegisteredUserLogin(string idNo)
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                var select = db.Query<Enroll>("select * from Enroll where idNumber='" + idNo + "'").FirstOrDefault();
                return select;

            }
        }

       


        public int Userid { get; set; }
    }
}
