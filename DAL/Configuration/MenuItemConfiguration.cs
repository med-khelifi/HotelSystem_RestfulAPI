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
    internal class MenuItemConfiguration : IEntityTypeConfiguration<MenuItem>
    {
        public void Configure(EntityTypeBuilder<MenuItem> entity)
        {
            entity.HasKey(e => e.ItemId).HasName("PK__MenuItem__727E83EB69B2488F");

            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.ImagePath).HasMaxLength(500);
            entity.Property(e => e.ItemName).HasMaxLength(300);
            entity.Property(e => e.Price).HasColumnType("smallmoney");
        }
    }
}
