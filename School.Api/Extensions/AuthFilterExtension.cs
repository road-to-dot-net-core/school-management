using Microsoft.Extensions.DependencyInjection;
using School.Api.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Api.Extensions
{
    public static class AuthFilterExtension
    {
        public static IServiceCollection AddAuthFilters(this IServiceCollection services)
        {
            services.AddTransient<AuthorizeAccessAttribute,AuthorizeAccessAttribute>();
            return services;
        }
    }
}
