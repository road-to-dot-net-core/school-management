using Microsoft.Extensions.DependencyInjection;
using School.Api.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Api.Extensions
{
    public static class HttpContextExtension
    {
        public static IServiceCollection AddHttpContextHelper(this IServiceCollection services)
        {
            services.AddScoped<HttpContextHelper, HttpContextHelper>();
            services.AddHttpContextAccessor();

            return services;
        }
    }
}

