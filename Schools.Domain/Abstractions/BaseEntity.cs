using System;

namespace Schools.Domain.Models
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public Guid? UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid? CreatedBy { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
