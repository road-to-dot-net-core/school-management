using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using FluentValidation.AspNetCore;
using School.Api.Options;
using School.Api.Extensions;
using School.Service.Access_Control;
using School.Domain.Repositories.Access_Control;
using School.Infra.Repositories.Access_Control;
using Schools.Domain.Repositories.Access_Control;
using AutoMapper;
using School.Api.Automapper;
using School.Contract.Results;

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
            services.AddSchoolDbContext(Configuration)
                    .AddSchoolSwagger()
                    .AddHttpContextHelper()
                    .AddJwtToken(Configuration)
                    .AddCorsConfig()
                    ;
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new CreateProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);


            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IFeatureRepository, FeatureRepository>();
            services.AddScoped<IPermissionRepository, PermissionRepository>();
            services.AddScoped<IRefreshTokenRepository, RefreshTokenRepository>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IIdentityService, IdentityService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddSingleton<IApiResult, ApiResult>();
            services.AddScoped<IPermissionService, PermissionService>();

            services.AddControllers().AddFluentValidation();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
          
            var swaggerOptions = new SwaggerOptions();
            Configuration.GetSection(nameof(SwaggerOptions)).Bind(swaggerOptions);
            app.UseSwagger();

            app.UseSwaggerUI(option =>
            {
                option.SwaggerEndpoint(swaggerOptions.UiEndpoint, swaggerOptions.Description);
            });
            app.UseAuthentication();
            
            app.UseRouting();
            app.UseCors("AllowOrigin");
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }


    }
}
