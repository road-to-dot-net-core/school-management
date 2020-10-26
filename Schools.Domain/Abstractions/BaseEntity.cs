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

        public Guid? DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public bool Deleted { get { return DeletedOn != null; } }
        public string DeleteReason { get; private set; }


    }
}
