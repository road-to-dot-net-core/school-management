using System;
using System.Collections.Generic;
using System.Text;

namespace Schools.Domain
{
    public class LevelClass
    {
        public Guid Id { get; private set; }
        public int Level { get; private set; }
        public string ClassName { get; private set; }
        public virtual List<Student> Students { get;  set; }
        public virtual List<ClassLevelTeacher> ClassTeachers { get; set; }

        public LevelClass()
        {

        }
        public LevelClass(int level,string className)
        {
            Id = Guid.NewGuid();
            Level = level;
            ClassName = className;
        }

    }
}
