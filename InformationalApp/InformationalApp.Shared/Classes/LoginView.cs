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
                var query = db.Query<Register>("select * from Enroll where email ='"+email+"' and password = '"+password+"'").Single();
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

     
    }
}
