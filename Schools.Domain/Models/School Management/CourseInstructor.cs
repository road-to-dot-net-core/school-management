using System;
using System.Collections.Generic;
using System.Text;

namespace Schools.Domain.Models
{
    public class CourseInstructor:BaseEntity
    {
        public Guid CourseId { get; set; }
        public virtual Course Course { get; set; }

        public Guid InstructorId { get; set; }
        public virtual Instructor Instructor { get; set; }

        public DateTime AssociatedOn { get; set; }
        public CourseInstructor()
        {

        }
    }
}
