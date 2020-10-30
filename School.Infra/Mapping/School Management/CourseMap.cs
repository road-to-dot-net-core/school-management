using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schools.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infra.Mapping
{
    public class CourseMap : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("COURSES");

            builder.HasKey(a => a.Id);
            builder.Property(a => a.Title).HasMaxLength(50).IsRequired(true);
            builder.Property(a => a.Description).HasMaxLength(500);

            builder.Property(a => a.DurationTicks).HasColumnType("bigint");
            builder.Ignore(a => a.Duration);



            builder.Property(aa => aa.CreatedOn).HasColumnName("CreatedOn").HasDefaultValue(DateTime.Now).IsRequired(true);
            builder.Property(aa => aa.CreatedBy).HasColumnName("CreatedBy").HasDefaultValue(null).IsRequired(false);

            builder.Property(aa => aa.UpdatedOn).HasColumnName("UpdatedOn").HasDefaultValue(null).IsRequired(false);
            builder.Property(aa => aa.UpdatedBy).HasColumnName("UpdatedBy").HasDefaultValue(null).IsRequired(false);
            builder.Property(a => a.Timestamp).IsRowVersion();

            builder.Ignore(aa => aa.Deleted);
            builder.Property(aa => aa.DeleteReason).HasColumnName("DeletReason").HasDefaultValue(null).HasMaxLength(250).IsRequired(false);
            builder.Property(aa => aa.DeletedBy).HasColumnName("DeletedBy").HasDefaultValue(null).IsRequired(false);
            builder.Property(aa => aa.DeletedOn).HasColumnName("DeletedOn").HasDefaultValue(null).IsRequired(false);


            //reflexiv relationship
            builder.HasOne(a => a.Parent)
                .WithMany(a => a.SubCourses)
                .HasForeignKey(a => a.ParentId)
                  .OnDelete(DeleteBehavior.NoAction);

            //category
            builder.HasOne(a => a.Category)
             .WithMany()
             .HasForeignKey(a => a.CategoryId)
               .OnDelete(DeleteBehavior.Cascade);

            //Course Instructors 
            builder.HasMany(a => a.CourseInstructors)
                          .WithOne(a => a.Course)
                          .HasForeignKey(a => a.CourseId)
                            .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(a => a.Branch)
             .WithMany()
             .HasForeignKey(a => a.BranchId)
             .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
