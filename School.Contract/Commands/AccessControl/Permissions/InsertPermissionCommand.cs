using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.Commands.AccessControl.Permissions
{
    public class InsertPermissionCommand
    {
        public string Label { get; set; }
        public string Description { get; set; }
        public Guid CreatedBy { get; set; }

        public List<Guid> Features { get; set; }
    }
}
