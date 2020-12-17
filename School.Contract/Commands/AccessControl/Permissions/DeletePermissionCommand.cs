using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.Commands.AccessControl.Permissions
{
    public class DeletePermissionCommand
    {
        public Guid Id { get; set; }
        public Guid DeletedBy { get; set; }
        public string Reason { get; set; }
    }
}
