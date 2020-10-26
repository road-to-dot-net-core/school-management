using Schools.Domain.Models;
using Schools.Domain.Models.School_Management;
using System;
using System.Collections.Generic;
using System.Text;

namespace Schools.Domain
{
    public class LevelClass:BaseEntity
    {
        public string ClassName { get; private set; }
        public Guid LevelId { get;private set; }
        public virtual Level Level { get; set; }

        public Guid BranchId { get; set; }
        public virtual Branch Branch { get; set; }

        public virtual ICollection<Student> Students { get; set; }


        public LevelClass()
        {
            Students = new List<Student>();

        }
        public LevelClass(Guid levelId, string className)
        {
            Id = Guid.NewGuid();
            LevelId = levelId;
            ClassName = className;
        }

    }
}
