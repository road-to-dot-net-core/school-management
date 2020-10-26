using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.Requests.Users
{
    public class RegisterUserRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Guid RoleId { get; set; }
        public Guid CreatedBy { get; set; }
        public string Password { get; set; }
    }
}
