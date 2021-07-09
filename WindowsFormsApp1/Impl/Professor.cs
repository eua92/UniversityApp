using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Impl
{
    public class Professor : Person
    {
        public short Age { get; set; }
        public string Rank { get; set; }
        public List<CoursesCategoryEnum> CAN_TEACH { get; set; }

        public Professor() : base()
        {
           
        }
    }
}
