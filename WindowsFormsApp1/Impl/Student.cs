using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Impl
{
    public class Student : Person
    {
        public string RegistrationNumber { get; set; }

        public Student() : base()
        {
                
        }

        public Student(
            string name, 
            string surname, 
            DateTime birthDate, 
            List<CoursesCategoryEnum> courses, 
            string registrationNumber) : base()
        {
            Name = name;
            Surname = surname;
            BirthDate = birthDate.Date;
            Courses = courses;
            RegistrationNumber = registrationNumber;
        }
    }
}
