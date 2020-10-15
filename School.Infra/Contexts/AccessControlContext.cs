using Microsoft.EntityFrameworkCore;
using School.Infra.Mapping;
using School.Infra.Mapping.Access_Control;
using School.Infra.Mapping.School_Management;
using Schools.Domain;
using Schools.Domain.Models;
using Schools.Domain.Models.Access_Control;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infra
{
    public class AccessControlContext : DbContext
    {
        public AccessControlContext(DbContextOptions<AccessControlContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FeatureMap());
            modelBuilder.ApplyConfiguration(new PermissionFeatureMap());
            modelBuilder.ApplyConfiguration(new PermissionMap());
            modelBuilder.ApplyConfiguration(new RoleMap());

            modelBuilder.ApplyConfiguration(new RolePermissionMap());
            modelBuilder.ApplyConfiguration(new SystemUserMap());

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Feature> Features { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }


    }
}
