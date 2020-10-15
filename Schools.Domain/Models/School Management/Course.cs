using Schools.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Schools.Domain
{
    public class Course : BaseEntity
    {
        public Course()
        {
            SubCourses = new List<Course>();
            IsActive = true;
        }
        public string Title { get; set; }
        public string Description { get; set; }

        public Int64 DurationTicks { get; set; }
        public TimeSpan Duration
        {
            get { return TimeSpan.FromTicks(DurationTicks); }
            set { DurationTicks = value.Ticks; }
        }
        public bool IsActive { get; set; }
        public Guid? ParentId { get; set; }
        public virtual Course Parent { get; set; }

        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<CourseInstructor> CourseInstructors { get; set; }
        public virtual ICollection<Course> SubCourses { get; set; }
    }
}
