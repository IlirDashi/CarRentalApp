using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Core.Data.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }

        public static void ConfigureForDb(EntityTypeBuilder<Person> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("Persons");
            entityTypeBuilder.HasKey(x => x.Id);
            entityTypeBuilder.Property(x => x.FullName)
                             .IsRequired()
                             .HasMaxLength(50);
            entityTypeBuilder.Property(x => x.PhoneNo)
                             .HasMaxLength(50);
            entityTypeBuilder.Property(x => x.Email)
                             .IsRequired()
                             .HasMaxLength(200);
            entityTypeBuilder.HasIndex(x => x.Email)
                             .IsUnique();
            entityTypeBuilder.Property(x => x.Password)
                             .HasMaxLength(200);
            entityTypeBuilder.Property(x => x.Role)
                             .HasMaxLength(20);

        }
    }
}
