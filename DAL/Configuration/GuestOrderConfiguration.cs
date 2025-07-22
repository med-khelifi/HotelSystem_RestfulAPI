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
    internal class GuestOrderConfiguration : IEntityTypeConfiguration<GuestOrder>
    {
        public void Configure(EntityTypeBuilder<GuestOrder> entity)
        {
            entity.HasKey(e => e.GuestOrderId).HasName("PK__GuestOrd__773A898AF6FE53D6");

            entity.Property(e => e.GuestOrderId).HasColumnName("GuestOrderID");
            entity.Property(e => e.BookingId).HasColumnName("BookingID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.GuestId).HasColumnName("GuestID");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.RoomServiceId).HasColumnName("RoomServiceID");

            entity.HasOne(d => d.Booking).WithMany(p => p.GuestOrders)
                .HasForeignKey(d => d.BookingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GuestOrde__Booki__7C1A6C5A");

            entity.HasOne(d => d.CreatedByUser).WithMany(p => p.GuestOrders)
                .HasForeignKey(d => d.CreatedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GuestOrde__Creat__74AE54BC");

            entity.HasOne(d => d.Guest).WithMany(p => p.GuestOrders)
                .HasForeignKey(d => d.GuestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GuestOrde__Guest__71D1E811");

            entity.HasOne(d => d.Room).WithMany(p => p.GuestOrders)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GuestOrde__RoomI__72C60C4A");

            entity.HasOne(d => d.RoomService).WithMany(p => p.GuestOrders)
                .HasForeignKey(d => d.RoomServiceId)
                .HasConstraintName("FK__GuestOrde__RoomS__0697FACD");
        }
    }
}
