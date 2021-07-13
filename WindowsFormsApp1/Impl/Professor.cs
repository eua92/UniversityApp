using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Impl
{
    public class Professor : Person
    {
        public ProfessorRankEnum Rank { get; set; }

        public Professor() : base()
        {

        }

        public Professor(
            string name,
            string surname,
            DateTime birthDate,
            List<CoursesCategoryEnum> courses,
            ProfessorRankEnum rank
            ) : base()
        {
            Name = name;
            Surname = surname;
            BirthDate = birthDate.Date;
            Courses = courses;
            Rank = rank;
        }
    }
}
