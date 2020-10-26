using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Api.Filters
{
    public class AuthorizeAccessAttribute : TypeFilterAttribute
    {
        public AuthorizeAccessAttribute(): base(typeof(AuthorizeAccessFilter))
        {

        }
        public AuthorizeAccessAttribute(string actionName) : base(typeof(AuthorizeAccessFilter))
        {
            Arguments = new object[] { actionName };
        }
    }
}
