using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Schools.Domain
{
    public class ClassLevelTeacher
    {
        public Guid TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }



        public Guid LevelClassId { get; set; }
        public virtual LevelClass LevelClass { get; set; }
        public ClassLevelTeacher()
        {

        }
        public ClassLevelTeacher(Guid levelId,Guid teacherId)
        {
            LevelClassId = levelId;
            TeacherId = teacherId;
        }   
    }
}
