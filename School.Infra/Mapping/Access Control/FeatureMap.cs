﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schools.Domain.Models;
using Schools.Domain.Models.Access_Control;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infra.Mapping.School_Management
{
    public class FeatureMap : IEntityTypeConfiguration<Feature>
    {
        public void Configure(EntityTypeBuilder<Feature> builder)
        {
            builder.ToTable("FEATURES");

            builder.HasKey(a => a.Id);
            builder.Property(a => a.Timestamp).IsRowVersion();

            builder.Property(aa => aa.Label).HasColumnName("Label").HasMaxLength(50);
            builder.Property(aa => aa.Controller).HasColumnName("Controller").HasMaxLength(50).IsRequired();
            builder.Property(aa => aa.ControllerActionName).HasColumnName("ControllerActionName").HasMaxLength(50).IsRequired(false);
            builder.Property(aa => aa.Description).HasColumnName("Description").HasMaxLength(500);
            builder.Property(aa => aa.Action).HasColumnName("Action").HasMaxLength(50).IsRequired();

            builder.Property(aa => aa.CreatedOn).HasColumnName("CreatedOn").HasDefaultValue(DateTime.Now).IsRequired(true);
            builder.Property(aa => aa.CreatedBy).HasColumnName("CreatedBy").HasDefaultValue(null).IsRequired(false);

            builder.Property(aa => aa.UpdatedOn).HasColumnName("UpdatedOn").HasDefaultValue(null).IsRequired(false);
            builder.Property(aa => aa.UpdatedBy).HasColumnName("UpdatedBy").HasDefaultValue(null).IsRequired(false);
            builder.Property(a => a.Timestamp).IsRowVersion();

            builder.Ignore(aa => aa.Deleted);
            builder.Property(aa => aa.DeleteReason).HasColumnName("DeletReason").HasDefaultValue(null).HasMaxLength(250).IsRequired(false);
            builder.Property(aa => aa.DeletedBy).HasColumnName("DeletedBy").HasDefaultValue(null).IsRequired(false);
            builder.Property(aa => aa.DeletedOn).HasColumnName("DeletedOn").HasDefaultValue(null).IsRequired(false);

            builder.Property(a => a.RoutingLink).HasMaxLength(50).IsRequired(false);
            builder.Property(a => a.Logo).HasMaxLength(50).IsRequired(false);

            //reflexiv relationship
            builder.HasOne(a => a.ParentFeature)
                .WithMany()
                .HasForeignKey(a => a.ParentId)
                  .OnDelete(DeleteBehavior.NoAction);


        }
    }
}
