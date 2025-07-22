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
    internal class RoomTypeConfiguration : IEntityTypeConfiguration<RoomType>
    {
        public void Configure(EntityTypeBuilder<RoomType> entity)
        {
            entity.HasKey(e => e.RoomTypeId).HasName("PK__RoomType__BCC89611C6B4CBBE");

            entity.HasIndex(e => e.RoomTypeTitle, "UQ__RoomType__E37A7CB411ACF533").IsUnique();

            entity.Property(e => e.RoomTypeId).HasColumnName("RoomTypeID");
            entity.Property(e => e.RoomTypeDescription).HasMaxLength(500);
            entity.Property(e => e.RoomTypePricePerNight).HasColumnType("smallmoney");
            entity.Property(e => e.RoomTypeTitle).HasMaxLength(50);
        }
    }
}
