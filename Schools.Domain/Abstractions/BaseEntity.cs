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




        public Guid? DeletedBy { get; private set; }
        public DateTime? DeletedOn { get; private set; }
        public bool Deleted { get { return DeletedOn != null; } }
        public string DeleteReason { get; private set; }

        public void MarkAsDeleted(Guid by,string reason)
        {
            DeleteReason = reason;
            DeletedBy = by;
            DeletedOn = DateTime.UtcNow;
        }


    }
}
