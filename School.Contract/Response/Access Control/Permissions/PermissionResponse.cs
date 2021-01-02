using School.Contract.ApiResults;
using School.Contract.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.Response.Access_Control.Permissions
{
    public class PermissionResponse: ISuccessResponse
    {
        public Guid Id { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public List<FeatureResponse> Features { get; set; }
    }
}
