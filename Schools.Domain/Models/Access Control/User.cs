using Schools.Domain.Abstractions;
using Schools.Domain.Models.Access_Control;
using System;
using System.Collections.Generic;
using System.Text;

namespace Schools.Domain.Models
{
    public class User : Person
    {
        public Guid RoleId { get; set; }
        public virtual Role Role { get; set; }
        public User()
        {

        }


    }
}
