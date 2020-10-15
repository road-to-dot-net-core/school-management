using Schools.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Schools.Domain
{
    public class Attendance : BaseEntity
    {
        public Guid StudentId { get; set; }
        public virtual Student Student { get; set; }
        public bool Attended { get; set; }
        public string Notes { get; set; }


        public Guid CourseOfferingSessionId { get; set; }
        public virtual CourseOfferingSession CourseOfferingSession { get; set; }

        public Attendance()
        {

        }
    }
}
