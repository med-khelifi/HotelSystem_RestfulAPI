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
    internal class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> entity)
        {
            entity.HasKey(e => e.ReservationId).HasName("PK__Reservat__B7EE5F04B141DD12");

            entity.Property(e => e.ReservationId).HasColumnName("ReservationID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastStatusDate).HasColumnType("datetime");
            entity.Property(e => e.NumberOfPeople).HasDefaultValue((byte)1);
            entity.Property(e => e.ReservationDate).HasColumnType("datetime");
            entity.Property(e => e.ReservationPersonId).HasColumnName("ReservationPersonID");
            entity.Property(e => e.RoomId).HasColumnName("RoomID");

            entity.HasOne(d => d.CreatedByUser).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.CreatedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reservati__Creat__5EBF139D");

            entity.HasOne(d => d.ReservationPerson).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.ReservationPersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reservati__Reser__5BE2A6F2");

            entity.HasOne(d => d.Room).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reservati__RoomI__5CD6CB2B");
        }
    }
}
