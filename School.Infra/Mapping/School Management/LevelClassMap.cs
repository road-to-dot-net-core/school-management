using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schools.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infra.Mapping
{
    public class LevelClassMap : IEntityTypeConfiguration<LevelClass>
    {
        public void Configure(EntityTypeBuilder<LevelClass> builder)
        {
            builder.ToTable("LEVEL_CLASSES");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.ClassName).HasMaxLength(50).IsRequired(true);

            builder.Property(aa => aa.CreatedOn).HasColumnName("CreatedOn").HasDefaultValue(DateTime.Now).IsRequired(true);
            builder.Property(aa => aa.CreatedBy).HasColumnName("CreatedBy").HasDefaultValue(null).IsRequired(false);

            builder.Property(aa => aa.UpdatedOn).HasColumnName("UpdatedOn").HasDefaultValue(null).IsRequired(false);
            builder.Property(aa => aa.UpdatedBy).HasColumnName("UpdatedBy").HasDefaultValue(null).IsRequired(false);
            builder.Property(a => a.Timestamp).IsRowVersion();

            builder.HasMany(a => a.Students)
                   .WithOne(a => a.LevelClass)
                   .HasForeignKey(a => a.LevelClassId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(a => a.Level)
                  .WithMany(a => a.LevelClasses)
                  .HasForeignKey(a => a.LevelId)
                  .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
