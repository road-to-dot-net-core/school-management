using Schools.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Schools.Domain
{
    public class Category : BaseEntity
    {
        public Category()
        {

        }
        public string Name { get; set; }
        public string Desription { get; set; }
        public bool IsActive { get; set; }
    }
}
