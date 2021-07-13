using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Impl
{
    public class Initialization
    {
        public University NewUniversity = new University();

        public void InitializeData()
        {
            InitializeCourses();
            InitalizeStudents();
            InitializeProfessors();
        }

        private void InitializeCourses()
        {
            NewUniversity.Courses.Add(new Course(
                            "1",
                            "Quantum Physics",
                            100,
                            CoursesCategoryEnum.Physics));

            NewUniversity.Courses.Add(new Course(
                "2",
                "Electo-Dynamics",
                50,
                CoursesCategoryEnum.Physics));

            NewUniversity.Courses.Add(new Course(
                "3",
                "Astronomy and Astrophysics",
                50,
                CoursesCategoryEnum.Physics));

            NewUniversity.Courses.Add(new Course(
               "4",
               "Analytical Mechanics",
               50,
               CoursesCategoryEnum.Physics));

            NewUniversity.Courses.Add(new Course(
               "5",
               "Thermodynamics",
               50,
               CoursesCategoryEnum.Physics));

            NewUniversity.Courses.Add(new Course(
                "6",
                "Basic Chemistry",
                50,
                CoursesCategoryEnum.Chemistry));

            NewUniversity.Courses.Add(new Course(
                "7",
                "Organic Chemistry",
                50,
                CoursesCategoryEnum.Chemistry));

            NewUniversity.Courses.Add(new Course(
                "8",
                "Inorganic Chemistry",
                50,
                CoursesCategoryEnum.Chemistry));

            NewUniversity.Courses.Add(new Course(
                "9",
                "Biochemistry",
                50,
                CoursesCategoryEnum.Chemistry));

            NewUniversity.Courses.Add(new Course(
                "10",
                "Analytical Chemistry",
                50,
                CoursesCategoryEnum.Chemistry));

            NewUniversity.Courses.Add(new Course(
                "11",
                "Financial I",
                50,
                CoursesCategoryEnum.Financial));

            NewUniversity.Courses.Add(new Course(
                "12",
                "Financial II",
                50,
                CoursesCategoryEnum.Financial));

            NewUniversity.Courses.Add(new Course(
                "13",
                "Financial III",
                50,
                CoursesCategoryEnum.Financial));

            NewUniversity.Courses.Add(new Course(
                "14",
                "Accounting I",
                50,
                CoursesCategoryEnum.Financial));

            NewUniversity.Courses.Add(new Course(
                "15",
                "Accounting II",
                50,
                CoursesCategoryEnum.Financial));

            NewUniversity.Courses.Add(new Course(
                "16",
                "Mathematics I",
                50,
                CoursesCategoryEnum.Mathematics));

            NewUniversity.Courses.Add(new Course(
                "17",
                "Algebra I",
                50,
                CoursesCategoryEnum.Mathematics));

            NewUniversity.Courses.Add(new Course(
                "18",
                "Algebra II",
                50,
                CoursesCategoryEnum.Mathematics));

            NewUniversity.Courses.Add(new Course(
                "19",
                "Geometry",
                50,
                CoursesCategoryEnum.Mathematics));

            NewUniversity.Courses.Add(new Course(
               "20",
               "Calculus",
               50,
               CoursesCategoryEnum.Mathematics));
        }

        private void InitalizeStudents()
        {
            
            NewUniversity.Students.Add(new Student(
                 "Fotis",
                 "Chrysoulas",
                 new DateTime(2000, 04, 15).Date,
                 new List<CoursesCategoryEnum>() { CoursesCategoryEnum.Chemistry, CoursesCategoryEnum.Financial },
                 "1231"));
            
            NewUniversity.Students.Add(new Student(
                "Dimitris",
                "Raptodimos",
                new DateTime(1998, 01, 10).Date,
                new List<CoursesCategoryEnum>() { CoursesCategoryEnum.Physics, CoursesCategoryEnum.Financial },
                "1232"));
            
            NewUniversity.Students.Add(new Student(
                 "Raine",
                 "Piercey",
                 new DateTime(1997, 12, 08).Date,
                 new List<CoursesCategoryEnum>() { CoursesCategoryEnum.Mathematics },
                 "1233"));
            
            NewUniversity.Students.Add(new Student(
                "Lizzy",
                "Lewnden",
                new DateTime(2000, 06, 14).Date,
                new List<CoursesCategoryEnum>() { CoursesCategoryEnum.Physics, CoursesCategoryEnum.Chemistry },
                "1234"));

            NewUniversity.Students.Add(new Student(
                 "Rudolf",
                 "Bomfield",
                 new DateTime(1997, 2, 23).Date,
                 new List<CoursesCategoryEnum>() { CoursesCategoryEnum.Financial },
                 "1235"));

            NewUniversity.Students.Add(new Student(
                "Cissy",
                "Aimer",
                new DateTime(1998, 06, 05).Date,
                new List<CoursesCategoryEnum>() { CoursesCategoryEnum.Chemistry },
                "1236"));

            NewUniversity.Students.Add(new Student(
                 "Kassey",
                 "Baythorp",
                 new DateTime(2003, 10, 03).Date,
                 new List<CoursesCategoryEnum>() { CoursesCategoryEnum.Physics},
                 "1237"));

            NewUniversity.Students.Add(new Student(
                "Sonya",
                "Lathleiffure",
                new DateTime(2002, 04, 13).Date,
                new List<CoursesCategoryEnum>() { CoursesCategoryEnum.Physics, CoursesCategoryEnum.Chemistry },
                "1238"));

            NewUniversity.Students.Add(new Student(
                 "Rickard",
                 "Schettini",
                 new DateTime(1998, 07, 12).Date,
                 new List<CoursesCategoryEnum>() { CoursesCategoryEnum.Financial },
                 "1239"));

            NewUniversity.Students.Add(new Student(
                "Shellysheldon",
                "Asker",
                new DateTime(2002, 03, 06).Date,
                new List<CoursesCategoryEnum>() { CoursesCategoryEnum.Mathematics, CoursesCategoryEnum.Financial },
                "1240"));

            NewUniversity.Students.Add(new Student(
                 "Cordell",
                 "Cooch",
                 new DateTime(2002, 08, 03).Date,
                 new List<CoursesCategoryEnum>() { CoursesCategoryEnum.Mathematics },
                 "1241"));

            NewUniversity.Students.Add(new Student(
                "Antonio",
                "Gerner",
                new DateTime(2001, 12, 04).Date,
                new List<CoursesCategoryEnum>() { CoursesCategoryEnum.Physics, CoursesCategoryEnum.Chemistry },
                "1242"));
        }

        private void InitializeProfessors()
        {
            NewUniversity.Professors.Add(new Professor(
                "Maria",
                "Papadopoulou",
                new DateTime(1970, 09, 04).Date,
                new List<CoursesCategoryEnum>() { CoursesCategoryEnum.Physics },
                ProfessorRankEnum.Associate));

            NewUniversity.Professors.Add(new Professor(
                "Odie",
                "Bril",
                new DateTime(1955, 02, 15).Date,
                new List<CoursesCategoryEnum>() { CoursesCategoryEnum.Chemistry },
                ProfessorRankEnum.Full));

            NewUniversity.Professors.Add(new Professor(
                "Leighton",
                "Embling",
                new DateTime(1960, 08, 23).Date,
                new List<CoursesCategoryEnum>() { CoursesCategoryEnum.Mathematics },
                ProfessorRankEnum.Full));

            NewUniversity.Professors.Add(new Professor(
                "Joceline",
                "Waistall",
                new DateTime(1975, 11, 06).Date,
                new List<CoursesCategoryEnum>() { CoursesCategoryEnum.Financial },
                ProfessorRankEnum.Associate));

            NewUniversity.Professors.Add(new Professor(
                "Bendix",
                "Boutellier",
                new DateTime(1980, 03, 10).Date,
                new List<CoursesCategoryEnum>() { CoursesCategoryEnum.Mathematics },
                ProfessorRankEnum.Assistant));
        }
    }
}
