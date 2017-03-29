﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseTable
{
    class Course
    {
        //private string courseID;
        //private string name;
        //private string courseDay;
        //private string startTime;

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

        }


    }
}
