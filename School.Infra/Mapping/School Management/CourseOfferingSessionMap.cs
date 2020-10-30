using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schools.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infra.Mapping
{
    public class CourseOfferingSessionMap : IEntityTypeConfiguration<CourseOfferingSession>
    {
        public void Configure(EntityTypeBuilder<CourseOfferingSession> builder)
        {
            builder.ToTable("COURSES_OFFERING_SESSIONS");

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


            builder.HasOne(a => a.Room)
                .WithMany()
                .HasForeignKey(a => a.RoomId)
                    .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(a => a.CourseOffering)
                  .WithMany(a => a.CourseOfferingSessions)
                  .HasForeignKey(a => a.CourseOfferingId)
                    .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
