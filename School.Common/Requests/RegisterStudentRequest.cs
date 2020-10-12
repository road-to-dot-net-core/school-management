using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Api.Requests
{
    public class RegisterStudentRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid LevelClass { get; set; }
    }
}
