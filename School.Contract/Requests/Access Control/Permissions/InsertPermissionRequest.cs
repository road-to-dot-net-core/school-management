using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.Requests.Access_Control.Permissions
{
    public class InsertPermissionRequest
    {
        public string Label { get; set; }
        public string Description { get; set; }

        public List<Guid> Features { get; set; }
    }
}
