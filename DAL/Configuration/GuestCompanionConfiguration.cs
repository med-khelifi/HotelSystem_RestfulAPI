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
    internal class GuestCompanionConfiguration : IEntityTypeConfiguration<GuestCompanion>
    {
        public void Configure(EntityTypeBuilder<GuestCompanion> entity)
        {
            entity.HasKey(e => e.GuestCompanionId).HasName("PK__GuestCom__82EE00495B28D436");

            entity.Property(e => e.GuestCompanionId).HasColumnName("GuestCompanionID");
            entity.Property(e => e.BookingId).HasColumnName("BookingID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GuestId).HasColumnName("GuestID");
            entity.Property(e => e.PersonId).HasColumnName("PersonID");

            entity.HasOne(d => d.Booking).WithMany(p => p.GuestCompanions)
                .HasForeignKey(d => d.BookingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GuestComp__Booki__6E01572D");

            entity.HasOne(d => d.CreatedByUser).WithMany(p => p.GuestCompanions)
                .HasForeignKey(d => d.CreatedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GuestComp__Creat__6EF57B66");

            entity.HasOne(d => d.Guest).WithMany(p => p.GuestCompanions)
                .HasForeignKey(d => d.GuestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GuestComp__Guest__6D0D32F4");

            entity.HasOne(d => d.Person).WithMany(p => p.GuestCompanions)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GuestComp__Perso__6C190EBB");
        }
    }
}
