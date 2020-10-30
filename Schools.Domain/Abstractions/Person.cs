using Schools.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Schools.Domain.Abstractions
{
    public abstract class Person:BaseEntity
    {
        public Person()
        {
            Id = Guid.NewGuid();
            IsActive = true;
        }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Notes { get; set; }
        public virtual string Email { get; set; }
        public virtual string Phone { get; set; }
        public virtual string AddressLine { get; set; }
        public bool IsActive { get; set; }
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
    }

}
