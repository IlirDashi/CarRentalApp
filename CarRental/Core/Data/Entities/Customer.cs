using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Core.Data.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public decimal Balance { get; set; }

        public static void ConfigureForDb(EntityTypeBuilder<Customer> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("Customers");
            entityTypeBuilder.HasKey(x => x.Id);
            entityTypeBuilder.Property(x => x.Name)
                             .IsRequired()
                             .HasMaxLength(50);
            entityTypeBuilder.Property(x => x.Surname)
                             .IsRequired()
                             .HasMaxLength(50);
            entityTypeBuilder.Property(x => x.PhoneNo)
                             .HasMaxLength(50)
                             .IsRequired();
            entityTypeBuilder.Property(x => x.Address)
                             .HasMaxLength(50);
            entityTypeBuilder.Property(x => x.Balance)
                             .HasPrecision(10, 2);
            //database relations

        }
    }
}
