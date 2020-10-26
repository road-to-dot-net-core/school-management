﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Api.Filters
{
    public class HttpContextHelper
    {
        private readonly Microsoft.AspNetCore.Http.IHttpContextAccessor _httpContextAccessor;
        public HttpContextHelper(Microsoft.AspNetCore.Http.IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public System.Guid GetUserId()
        {
            return System.Guid.Parse(_httpContextAccessor.HttpContext.User.
                Claims.Single(x => x.Type == "sub").Value);
        }


    }
}
