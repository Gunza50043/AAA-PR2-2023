using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2
{
    internal class Student
    {
        private string _studentName;
        public string StringName
        {
            get => _studentName;
            set => _studentName = value;
        }

        
        //-------------------------

        private City _city;
        private City City
        {
            get => _city;
        }
        public string CityName
        {
            get { return City != null ? City.CityName : "не назначенн"; }
            set { return; }
        }
        //--------------------------------
        private Predmet _predmet;
        private Predmet Predmet
        {
            get => _predmet;
            set=> _predmet = value;
        }
        public string TitlePredmet
        {
            get { return Predmet != null ? Predmet.PredmetName : "не назначенн"; }
            set { return; }
        }

        private EducationForm _educForm;
        private EducationForm EducForm
        {
            get => _educForm;
        }
        public string TitleEducForm
        {
            get { return EducForm != null ? EducForm.EducForm : "не назначенн"; }
            set { return; }
        }

        private Group _group;
        private Group Group
        {
            get => _group;
        }
        public string TitleGroup
        {
            get { return Group != null ? Group.TitleGtoup : "не назначенн"; }
            set { return; }
        }

        private int _ocenca;

        public int Ocenca
        {
            get => _ocenca;
            set { _ocenca = value; }
        }

        public Student (string studentName, City city, Predmet predmet, EducationForm educationForm, Group group, int ocenca)
        {
            _studentName = studentName;
            _city = city;
            _predmet = predmet;
            _educForm = educationForm;
            _group = group;
            _ocenca = ocenca;
        }
    }
}
