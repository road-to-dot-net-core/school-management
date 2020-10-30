using Schools.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Schools.Domain.Models
{
    public class CourseOfferingDay : BaseEntity
    {
        public Days Day { get; set; }

        public Int64 StartTimeTicks { get; set; }
        public TimeSpan StartTime
        {
            get { return TimeSpan.FromTicks(StartTimeTicks); }
            set { StartTimeTicks = value.Ticks; }
        }

        public Int64 EndTimeTicks { get; set; }
        public TimeSpan EndTime
        {
            get { return TimeSpan.FromTicks(StartTimeTicks); }
            set { StartTimeTicks = value.Ticks; }
        }


        public Guid CourseOfferingId { get; set; }
        public virtual CourseOffering CourseOffering { get; set; }

        public CourseOfferingDayFrequency Frequency { get; set; }
        public CourseOfferingDay()
        {

        }
    }
}
