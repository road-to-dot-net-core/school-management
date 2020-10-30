using Schools.Domain.Abstractions;
using Schools.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Schools.Domain
{
    public class Instructor : Person
    {
        public Instructor()
        {
            CourseInstructors = new List<CourseInstructor>();
        }
        public DateTime? HireDate { get; set; }
        public virtual ICollection<CourseInstructor> CourseInstructors { get; set; }
    }
}
