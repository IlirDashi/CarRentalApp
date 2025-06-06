
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Core.Data.Entities
{
    public class Rental
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public DateTime RentalStart { get; set; }
        public DateTime RentalEnd { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }

        public static void ConfigureForDb(EntityTypeBuilder<Rental> entityTypeBuilder)
        {

            entityTypeBuilder.ToTable("Rentals");
            entityTypeBuilder.HasKey(x => x.Id);
            entityTypeBuilder.Property(x => x.RentalStart)
                             .IsRequired();
            entityTypeBuilder.Property(x => x.RentalEnd)
                             .IsRequired();
            entityTypeBuilder.Property(x => x.TotalPrice)
                             .HasPrecision(10, 2)
                             .IsRequired();
            entityTypeBuilder.Property(x => x.Status)
                             .HasMaxLength(50)
                             .IsRequired();

            entityTypeBuilder.HasOne(x => x.Customer)
                             .WithMany()
                             .HasForeignKey(x => x.CustomerId)
                             .OnDelete(DeleteBehavior.Restrict);
            entityTypeBuilder.HasOne(x => x.Car)
                             .WithMany()
                             .HasForeignKey(x => x.CarId)
                             .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
