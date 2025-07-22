using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configuration
{
    internal class ErrorLogConfiguration : IEntityTypeConfiguration<ErrorLog>
    {
        public void Configure(EntityTypeBuilder<ErrorLog> entity)
        {
            entity.HasKey(e => e.ErrorId).HasName("PK__ErrorLog__358565CA9696CAEE");

            entity.Property(e => e.ErrorId).HasColumnName("ErrorID");
            entity.Property(e => e.ErrorMessage).HasMaxLength(500);
            entity.Property(e => e.ExceptionType).HasMaxLength(200);
            entity.Property(e => e.OccurredDate).HasColumnType("datetime");
        }
    }
}
