using Schools.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Schools.Domain
{
    public class Room:BaseEntity
    {
        public Room()
        {
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public bool IsActive { get; set; }
    }
}
