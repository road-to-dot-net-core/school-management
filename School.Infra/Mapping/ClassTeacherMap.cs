using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schools.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infra.Mapping
{
    public class ClassTeacherMap : IEntityTypeConfiguration<ClassLevelTeacher>
    {
        public void Configure(EntityTypeBuilder<ClassLevelTeacher> builder)
        {
            builder.ToTable("LevelClass_Teacher");
            builder.HasKey(a => new { a.TeacherId, a.LevelClassId });


           
            builder.HasOne(a => a.Teacher)
                .WithMany()
                .HasForeignKey(a => a.TeacherId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
