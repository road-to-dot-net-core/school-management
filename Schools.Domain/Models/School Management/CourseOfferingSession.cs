using Schools.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Schools.Domain
{
    public class CourseOfferingSession:BaseEntity
    {
        public CourseOfferingSession()
        {
        }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool Canceled { get; set; }
        public Guid RoomId { get; set; }
        public virtual Room Room{ get; set; }
        public Guid CourseOfferingId { get; set; }
        public virtual CourseOffering CourseOffering { get; set; }

    }
}
