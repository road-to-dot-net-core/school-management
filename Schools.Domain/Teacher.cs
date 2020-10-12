using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Schools.Domain
{
    public class Teacher
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Grade { get; set; }
        public Teacher()
        {

        }
        public Teacher(string firstName,string lastName,string grade)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;

        }   
    }
}
