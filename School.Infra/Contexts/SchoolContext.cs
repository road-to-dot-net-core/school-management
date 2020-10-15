using Microsoft.EntityFrameworkCore;
using School.Infra.Mapping;
using School.Infra.Mapping.School_Management;
using Schools.Domain;
using Schools.Domain.Models;
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
            modelBuilder.ApplyConfiguration(new AdminStaffMap());
            modelBuilder.ApplyConfiguration(new AttendanceMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CourseInstructorMap());


            modelBuilder.ApplyConfiguration(new CourseMap());
            modelBuilder.ApplyConfiguration(new CourseOfferingDayMap());

            modelBuilder.ApplyConfiguration(new CourseOfferingSessionMap());
            modelBuilder.ApplyConfiguration(new InstructorMap());

            modelBuilder.ApplyConfiguration(new LevelClassMap());
            modelBuilder.ApplyConfiguration(new LevelMap());

            modelBuilder.ApplyConfiguration(new OrganizationMap());
            modelBuilder.ApplyConfiguration(new RoomMap());

            modelBuilder.ApplyConfiguration(new StudentMap());
          
            modelBuilder.ApplyConfiguration(new CourseOfferingMap());


            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<LevelClass> LevelClasses { get; set; }
        public virtual DbSet<AdminStaff> AdminStaffs { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CourseOfferingDay> CourseOfferingDays { get; set; }

        public virtual DbSet<CourseOffering> CourseOfferings { get; set; }
        public virtual DbSet<CourseOfferingSession> CourseOfferingSessions { get; set; }


        public virtual DbSet<Instructor> Instructors { get; set; }

        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<Level> Levels { get; set; }

        public virtual DbSet<Room> Rooms { get; set; }


      


    }
}
