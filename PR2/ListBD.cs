using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2
{
    public class ListBD
    {
        private Random random = new Random();
        private int RandomOcenca
        {
            get => random.Next(2, 5);
        }
        internal List<Student> StudentList { get; set; }
        public void Initialize()
        {
            StudentList = new List<Student>
            {
                new Student (new string ("Петренко Качун Пердотавич"),new City ("Уфа"), new Predmet("Матеша"), new EducationForm("Очная"), new Group("ЫЫ-21"),RandomOcenca  ),
                new Student (new string ("Потато Виктор Леонидович"),new City ("Зажопино"), new Predmet("Геометрика"), new EducationForm("Очная"), new Group("ЫЫ-21"),RandomOcenca  ),
                new Student (new string ("Сунь хунь вчай"),new City ("Зажопино"), new Predmet("Геометрика"),new EducationForm("Заочная"), new Group("ЫЫ-21"), RandomOcenca  ),
                new Student (new string ("Вынь су хим "),new City ("Зажопино"), new Predmet("Геометрика"),new EducationForm("Очная"), new Group("ЫЫ-21"), RandomOcenca  ),
                new Student (new string ("Цин гей во"),new City ("Зажопино"), new Predmet("Геометрика"),new EducationForm("Заочная"), new Group("ЫЫ-21"), RandomOcenca  ),
                new Student (new string ("Валера"),new City ("Челябинск"), new Predmet("Жизнь"), new EducationForm("Очная"), new Group("ЫЫ-21"),RandomOcenca  ),
            };
        }
    }
}
