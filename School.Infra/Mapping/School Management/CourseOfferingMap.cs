using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schools.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infra.Mapping
{
    public class CourseOfferingMap : IEntityTypeConfiguration<CourseOffering>
    {
        public void Configure(EntityTypeBuilder<CourseOffering> builder)
        {
            builder.ToTable("COURSES_OFFERING");

            builder.HasKey(a => a.Id);




            builder.Property(aa => aa.CreatedOn).HasColumnName("CreatedOn").HasDefaultValue(DateTime.Now).IsRequired(true);
            builder.Property(aa => aa.CreatedBy).HasColumnName("CreatedBy").HasDefaultValue(null).IsRequired(false);

            builder.Property(aa => aa.UpdatedOn).HasColumnName("UpdatedOn").HasDefaultValue(null).IsRequired(false);
            builder.Property(aa => aa.UpdatedBy).HasColumnName("UpdatedBy").HasDefaultValue(null).IsRequired(false);
            builder.Property(a => a.Timestamp).IsRowVersion();

            builder.Ignore(aa => aa.Deleted);
            builder.Property(aa => aa.DeleteReason).HasColumnName("DeletReason").HasDefaultValue(null).HasMaxLength(250).IsRequired(false);
            builder.Property(aa => aa.DeletedBy).HasColumnName("DeletedBy").HasDefaultValue(null).IsRequired(false);
            builder.Property(aa => aa.DeletedOn).HasColumnName("DeletedOn").HasDefaultValue(null).IsRequired(false);


            builder.HasOne(a => a.Course)
                .WithMany()
                .HasForeignKey(a => a.CourseId)
                  .OnDelete(DeleteBehavior.Cascade);


            builder.HasOne(a => a.LevelClass)
                    .WithMany()
                    .HasForeignKey(a => a.LevelClassId)
                      .OnDelete(DeleteBehavior.Cascade);


            builder.HasOne(a => a.Instructor)
                    .WithMany()
                    .HasForeignKey(a => a.InstructorId)
                      .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(a => a.DefaultRoom)
                   .WithMany()
                   .HasForeignKey(a => a.DefaultRoomId)
                     .OnDelete(DeleteBehavior.NoAction);




            builder.HasMany(a => a.OfferingDays)
               .WithOne(a => a.CourseOffering)
               .HasForeignKey(a => a.CourseOfferingId)
                 .OnDelete(DeleteBehavior.Cascade);



        }
    }
}
