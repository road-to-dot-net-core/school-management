using System;
using System.Collections.Generic;
using System.Text;

namespace Schools.Domain.Models.School_Management
{
    public class Branch : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Branch()
        {

        }
    }
}
