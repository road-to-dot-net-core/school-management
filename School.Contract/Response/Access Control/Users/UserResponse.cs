using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.Response.Access_Control.Identity
{
    public class UserResponse
    {
        public Guid Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public DateTime? LastConnexionOn { get; set; }


        //remember to remove after
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
