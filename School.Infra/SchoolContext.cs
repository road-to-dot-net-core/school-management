using Microsoft.EntityFrameworkCore;
using School.Infra.Mapping;
using Schools.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infra
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentMap());
            modelBuilder.ApplyConfiguration(new TeacherMap());
            modelBuilder.ApplyConfiguration(new LevelClassMap());
            modelBuilder.ApplyConfiguration(new ClassTeacherMap());

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<LevelClass> LevelClasses { get; set; }



    }
}
