﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Schools.Domain.Models
{
    public class Organization : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Organization()
        {

        }
    }
}
