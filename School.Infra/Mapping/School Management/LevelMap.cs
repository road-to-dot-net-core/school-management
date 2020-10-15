using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schools.Domain;
using Schools.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infra.Mapping
{
    public class LevelMap : IEntityTypeConfiguration<Level>
    {
        public void Configure(EntityTypeBuilder<Level> builder)
        {
            builder.ToTable("LEVELS");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name).HasMaxLength(50).IsRequired(true);

            builder.Property(aa => aa.CreatedOn).HasColumnName("CreatedOn").HasDefaultValue(DateTime.Now).IsRequired(true);
            builder.Property(aa => aa.CreatedBy).HasColumnName("CreatedBy").HasDefaultValue(null).IsRequired(false);

            builder.Property(aa => aa.UpdatedOn).HasColumnName("UpdatedOn").HasDefaultValue(null).IsRequired(false);
            builder.Property(aa => aa.UpdatedBy).HasColumnName("UpdatedBy").HasDefaultValue(null).IsRequired(false);
            builder.Property(a => a.Timestamp).IsRowVersion();

            //
            builder.HasMany(a => a.LevelClasses)
                   .WithOne(a => a.Level)
                   .HasForeignKey(a => a.LevelId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
