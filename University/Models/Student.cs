using System.Collections.Generic;
using System;

namespace University.Models
{
    public class Student
    {
        public Student()
        {
            this.JoinEntities = new HashSet<CourseStudent>();
        }

        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime DateOfEnrollment { get; set; }


        public virtual ICollection<CourseStudent> JoinEntities { get;}
    }
}