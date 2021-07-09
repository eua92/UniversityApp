using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Impl
{
    public class Student : Person
    {
        public string Registration_Number { get; set; }
        public int _Age { get; set; }
        public List<CoursesCategoryEnum> CAN_LEARN { get; set; }

        public Student() : base()
        {
                
        }
    }
}
