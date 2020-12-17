using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.Commands.AccessControl.Permissions
{
    public class UpdatePermissionCommand
    {
        public Guid Id { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public Guid UpdatedBy { get; set; }

        public List<Guid> Features { get; set; }
    }
}
