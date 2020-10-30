using Schools.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Schools.Domain.Models
{
    public class AdminStaff:Person
    {
        public AdminStaff()
        {

        }
        public Guid OrgId { get; set; }
        public virtual Organization Organization { get; set; }
    }
}
