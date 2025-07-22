using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configuration
{
    internal class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> entity)
        {
           
                entity.HasKey(e => e.PersonId).HasName("PK__People__AA2FFB8504A21DDD");

                entity.HasIndex(e => e.NationalNo, "UQ__People__E9AA1A6592DF0DD8").IsUnique();

                entity.Property(e => e.PersonId).HasColumnName("PersonID");
                entity.Property(e => e.Address).HasMaxLength(200);
                entity.Property(e => e.BirthDate).HasColumnType("datetime");
                entity.Property(e => e.Email).HasMaxLength(150);
                entity.Property(e => e.FirstName).HasMaxLength(100);
                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
                entity.Property(e => e.LastName).HasMaxLength(100);
                entity.Property(e => e.NationalNo).HasMaxLength(20);
                entity.Property(e => e.NationalityCountryId).HasColumnName("NationalityCountryID");
                entity.Property(e => e.PersonalImagePath).HasMaxLength(500);
                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.HasOne(d => d.NationalityCountry).WithMany(p => p.People)
                    .HasForeignKey(d => d.NationalityCountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__People__National__3B75D760");

        }
    }
}
