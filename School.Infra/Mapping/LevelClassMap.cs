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
            builder.ToTable("Level_Classes");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.ClassName).HasMaxLength(50).IsRequired(true);

            //
            builder.HasMany(a => a.ClassTeachers)
                   .WithOne(a => a.LevelClass)
                   .HasForeignKey(a => a.LevelClassId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
