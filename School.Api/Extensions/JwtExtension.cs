﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using School.Infra;
using School.Api.Options;
using School.Common.Auth;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.CodeAnalysis.Options;

namespace School.Api.Extensions
{
    public static class JwtExtension
    {

        public static IServiceCollection AddJwtToken(this IServiceCollection services, IConfiguration configuration)
        {
            var jwtOptions = configuration.GetSection("jwt");
            services.Configure<JwtOptions>(jwtOptions);//inject IOption<JwtOptions>


            //var jwtObj = new JwtOptions(); -- inject JwtOptions
            //jwtOptions.Bind(jwtObj);
            //services.AddSingleton(jwtObj);


            var jwtOpt = jwtOptions.Get<JwtOptions>();
            var key = Encoding.ASCII.GetBytes(jwtOpt.SecretKey);

            services.AddSingleton<IEncrypter, Encrypter>();
            services.AddScoped<IJwtHandler, JwtHandler>();

            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false,
                RequireExpirationTime = false,
                ValidateLifetime = true

            };

            services.AddSingleton(tokenValidationParameters);

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.SaveToken = true;
                x.TokenValidationParameters = tokenValidationParameters;

                x.RequireHttpsMetadata = false;
            });



            return services;
        }

    }
}
