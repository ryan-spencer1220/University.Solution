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
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<CourseStudent> JoinEntities { get;}
    }
}