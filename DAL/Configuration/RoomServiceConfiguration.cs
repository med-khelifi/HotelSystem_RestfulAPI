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
    internal class RoomServiceConfiguration : IEntityTypeConfiguration<RoomService>
    {
        
        public void Configure(EntityTypeBuilder<RoomService> entity)
        {
            entity.HasKey(e => e.RoomServiceId).HasName("PK__RoomServ__A11E84A1809FEEA3");

            entity.Property(e => e.RoomServiceId).HasColumnName("RoomServiceID");
            entity.Property(e => e.RoomServiceDescription).HasMaxLength(500);
            entity.Property(e => e.RoomServiceFees).HasColumnType("smallmoney");
            entity.Property(e => e.RoomServiceTitle).HasMaxLength(50);
        }
    }
}
