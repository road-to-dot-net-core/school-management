using System;
using System.Collections.Generic;
using System.Text;

namespace Schools.Domain
{
    public class Student
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public virtual LevelClass LevelClass { get; set; }
        public Guid LevelClassId { get; set; }

        public Student()
        {

        }
        public Student(string firstName,string lastName,Guid levelId)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            LevelClassId = levelId;
        }


    }
}
