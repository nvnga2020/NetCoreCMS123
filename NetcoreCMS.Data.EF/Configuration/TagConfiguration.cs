using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetcoreCMS.Data.EF.Extensions;
using NetcoreCMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetcoreCMS.Data.EF.Configuration
{
    public class TagConfiguration : DbEntityConfiguration<Tag>
    {
        public override void Configure(EntityTypeBuilder<Tag> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(50).IsRequired().HasColumnType("varchar(50");
        }

    }
}
