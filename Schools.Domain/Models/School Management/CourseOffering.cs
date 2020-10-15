using Schools.Domain.Enums;
using Schools.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Schools.Domain
{
    public class CourseOffering:BaseEntity
    {
        public CourseOffering()
        {
            CourseOfferingSessions = new List<CourseOfferingSession>();
            OfferingDays = new List<CourseOfferingDay>();
            State = CourseOfferingState.Waiting;
        }

        public CourseOfferingState State { get; set; }
        public DateTime? StartDate { get; set; }

        public Guid CourseId { get; set; }
        public virtual Course Course { get; set; }

        public Guid LevelClassId { get; set; }
        public virtual LevelClass LevelClass { get; private set; }

        public Guid InstructorId { get; set; }
        public virtual  Instructor Instructor { get; set; }

        public Guid DefaultRoomId { get; set; }
        public virtual Room DefaultRoom { get; set; }

        public virtual ICollection<CourseOfferingSession> CourseOfferingSessions { get; set; }
        public virtual ICollection<CourseOfferingDay> OfferingDays { get; set; }


    }

}
