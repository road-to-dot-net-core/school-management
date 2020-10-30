using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.Response.Access_Control
{
    public class FeatureResponse
    {
        public Guid Id { get; set; }
        public String Label { get; set; }
        public String Description { get; set; }
        public String Controller { get; set; }
        public String Action { get; set; }
    }
}
