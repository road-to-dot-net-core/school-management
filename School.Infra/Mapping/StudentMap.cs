using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schools.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infra.Mapping
{
    public class StudentMap : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.FirstName).HasMaxLength(50).IsRequired(true);
            builder.Property(a => a.LastName).HasMaxLength(50).IsRequired(true);

            //
            builder.HasOne(a => a.LevelClass)
                   .WithMany(a => a.Students)
                   .HasForeignKey(a => a.LevelClassId)
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
