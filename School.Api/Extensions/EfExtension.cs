using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using School.Infra;


namespace School.Api.Extensions
{
    public static class EfExtension
    {
        public static IServiceCollection AddSchoolDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextPool<SchoolContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SchoolConnectionString"))
                .UseLazyLoadingProxies();

            });

            services.AddDbContextPool<AccessControlContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SchoolConnectionString"))
                .UseLazyLoadingProxies();

            });

            return services;
        }
    }
}
