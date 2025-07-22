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
    internal class GuestOrdersViewConfiguration : IEntityTypeConfiguration<GuestOrdersView>
    {
        public void Configure(EntityTypeBuilder<GuestOrdersView> entity)
        {
            entity
                .HasNoKey()
                .ToView("GuestOrders_View");

            entity.Property(e => e.BookingId).HasColumnName("Booking ID");
            entity.Property(e => e.Fees).HasColumnType("money");
            entity.Property(e => e.GuestName)
                .HasMaxLength(201)
                .HasColumnName("Guest Name");
            entity.Property(e => e.OrderDate)
                .HasColumnType("datetime")
                .HasColumnName("Order Date");
            entity.Property(e => e.OrderId).HasColumnName("Order ID");
            entity.Property(e => e.OrderType)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("Order Type");
            entity.Property(e => e.RoomNumber)
                .HasMaxLength(10)
                .HasColumnName("Room Number");
        }
    }
}
