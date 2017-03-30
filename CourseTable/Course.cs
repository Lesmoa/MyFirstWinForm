using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseTable
{
    /// <summary>
    /// Entity class
    /// </summary>
    class Course
    {
        public string CourseID { get; set;}
        public string Name { get; set; }
        public string CourseDay { get; set; }
        public string StartTime { get; set; }

        public string DisplayTime
        {
            get
            {
                return StartTime + " " + CourseDay;
            }
            set { }
        }
    }
}
