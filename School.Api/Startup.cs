using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using School.Infra;
using School.Domain.Repositories;
using School.Infra.Repositories;
using School.Service;
using FluentValidation;
using School.Api.Requests;
using School.Api.Validations;
using FluentValidation.AspNetCore;

namespace School.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<SchoolContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("SchoolConnectionString"))
                .UseLazyLoadingProxies();

            });
           // services.AddFluentValidation();
            services.AddSingleton<IValidator<AddLevelClassRequest>, AddLevelClassReqValidator>();


            services.AddScoped<ILevelClassRepository, LevelClassRepository>();
            services.AddScoped<ILevelClassService, LevelClassService>();

            services.AddControllers().AddFluentValidation();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
