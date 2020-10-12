using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schools.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infra.Mapping
{
    public class TeacherMap : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.ToTable("Teachers");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.FirstName).HasMaxLength(50).IsRequired(true);
            builder.Property(a => a.LastName).HasMaxLength(50).IsRequired(true);
            builder.Property(a => a.Grade).HasMaxLength(50).IsRequired(true);


        }
    }
}
