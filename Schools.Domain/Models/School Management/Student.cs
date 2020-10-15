using Schools.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Schools.Domain
{
    public class Student:Person
    {

        public virtual LevelClass LevelClass { get; set; }
        public Guid LevelClassId { get; set; }

        public Student()
        {

        }
        public Student(string firstName,string lastName,Guid levelId)
        {
            FirstName = firstName;
            LastName = lastName;
            LevelClassId = levelId;
        }


    }
}
