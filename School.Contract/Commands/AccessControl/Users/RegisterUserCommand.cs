using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.Commands.AccessControl.Users
{
    public class RegisterUserCommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Guid RoleId { get; set; }
        public string Password { get; set; }

        public Guid CreatedBy { get; set; }
    }
}
