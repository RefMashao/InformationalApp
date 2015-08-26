using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Windows.UI.Xaml;
using System.Collections.ObjectModel;

namespace InformationalApp.Classes
{
    class LoginView
    {

        private InformationalApp.App app = (Application.Current as App);
         private ObservableCollection<CoursesViewModel> course;
         private ObservableCollection<PossibleViewModel> name;
        public ObservableCollection<CoursesViewModel> Course
        {
            get { return course; }

            set
            {
                if (course == value)
                {
                    return;
                }
                course = value;

            }
        }
        public ObservableCollection<CoursesViewModel> getCourses(int id)
        {
            course = new ObservableCollection<CoursesViewModel>();
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                //var query = db.Table<Courses>();
                var query = db.Query<Courses>("select * from courses where institution = "+id);
                foreach (var ins in query)
                {
                    var ins1 = new CoursesViewModel()
                    {
                       ID = ins.Id,
                       Name = ins.course,
                       Institution = ins.institution
                    };
                    course.Add(ins1);
                }
            }
            return course;
        }
        public ObservableCollection<InstitutionViewModel> courses
        {
            get { return courses; }

            set
            {
                if (courses == value)
                {
                    return;
                }
                courses = value;

            }
        }

        public ObservableCollection<PossibleViewModel> getPossibleCareer(string names)
        {
            name = new ObservableCollection<PossibleViewModel>();
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                //var query = db.Table<Courses>();
                var query = db.Query<Possible_Careers>("select * from Possible_Careers where course ='" + names + "'");
                foreach (var ins in query)
                {
                    var ins1 = new PossibleViewModel()
                    {
                        ID = ins.Id,
                        Name = ins.name,
                        Course = ins.course
                    };
                    name.Add(ins1);
                }
            }
            return name;
        }

        private ObservableCollection<InstitutionViewModel> institution;
        public ObservableCollection<InstitutionViewModel> institutions
        {
            get { return institution; }

            set
            {
                if (institution == value)
                {
                    return;
                }
                institution = value;

            }
        }
        public ObservableCollection<InstitutionViewModel> getAllInstitution()
        {
            institution = new ObservableCollection<InstitutionViewModel>();
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                var query = db.Table<Institution>();

                foreach (var ins in query)
                {
                    var ins1 = new InstitutionViewModel()
                    {
                       ID = ins.Id,
                       Name = ins.insitution
                    };
                    institution.Add(ins1);
                }
            }
            return institution;
        }
        public Register getData(string email,string password)
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                var query = db.Query<Register>("select * from Enroll where email ='" + email + "' and password = '" + password + "'").FirstOrDefault();
                return query;
            }
        }
        public Institution getInstitutionId(string name)
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                var query = db.Query<Institution>("select * from Institution where insitution ='" + name + "'").FirstOrDefault();
                return query;
            }
        }
        public Possible_Careers getCourseId(string name)
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                var query = db.Query<Possible_Careers>("select * from Possible_Careers where course ='" + name + "'").FirstOrDefault();
                return query;
            }
        }
     
    }
}
