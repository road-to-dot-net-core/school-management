using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schools.Domain;
using Schools.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infra.Mapping
{
    public class CourseInstructorMap : IEntityTypeConfiguration<CourseInstructor>
    {
        public void Configure(EntityTypeBuilder<CourseInstructor> builder)
        {
            builder.ToTable("COURSES_INSTRUCTORS");

            builder.HasKey(a => a.Id);

            builder.Property(aa => aa.CreatedOn).HasColumnName("CreatedOn").HasDefaultValue(DateTime.Now).IsRequired(true);
            builder.Property(aa => aa.CreatedBy).HasColumnName("CreatedBy").HasDefaultValue(null).IsRequired(false);

            builder.Property(aa => aa.UpdatedOn).HasColumnName("UpdatedOn").HasDefaultValue(null).IsRequired(false);
            builder.Property(aa => aa.UpdatedBy).HasColumnName("UpdatedBy").HasDefaultValue(null).IsRequired(false);
            builder.Property(a => a.Timestamp).IsRowVersion();

            builder.Property(aa => aa.AssociatedOn).HasColumnName("AssociatedOn").HasDefaultValue(DateTime.Now).IsRequired(true);


            builder.HasOne(a => a.Course)
                .WithMany(a => a.CourseInstructors)
                .HasForeignKey(a => a.CourseId)
                  .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(a => a.Instructor)
              .WithMany(a => a.CourseInstructors)
              .HasForeignKey(a => a.InstructorId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
