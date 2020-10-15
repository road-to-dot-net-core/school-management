using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schools.Domain;
using Schools.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infra.Mapping
{
    public class CourseOfferingDayMap : IEntityTypeConfiguration<CourseOfferingDay>
    {
        public void Configure(EntityTypeBuilder<CourseOfferingDay> builder)
        {
            builder.ToTable("COURSE_OFFERING_DAYS");

            builder.HasKey(a => a.Id);

            builder.Property(aa => aa.CreatedOn).HasColumnName("CreatedOn").HasDefaultValue(DateTime.Now).IsRequired(true);
            builder.Property(aa => aa.CreatedBy).HasColumnName("CreatedBy").HasDefaultValue(null).IsRequired(false);

            builder.Property(aa => aa.UpdatedOn).HasColumnName("UpdatedOn").HasDefaultValue(null).IsRequired(false);
            builder.Property(aa => aa.UpdatedBy).HasColumnName("UpdatedBy").HasDefaultValue(null).IsRequired(false);
            builder.Property(a => a.Timestamp).IsRowVersion();


            builder.Property(a => a.StartTimeTicks).HasColumnType("bigint");
            builder.Ignore(a => a.StartTime);


            builder.Property(a => a.EndTimeTicks).HasColumnType("bigint");
            builder.Ignore(a => a.EndTime);

            builder.HasOne(a => a.CourseOffering)
                   .WithMany(a => a.OfferingDays)
                   .HasForeignKey(a => a.CourseOfferingId)
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
