
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Core.Data.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string BodyType { get; set; }
        public string Colour { get; set; }
        public int Mileage { get; set; }
        public int Year { get; set; }
        public decimal RentalPricePerDay { get; set; }
        public string LicensePlate { get; set; }
        public bool IsAvailable { get; set; }
        public string FuelType { get; set; }
        public string Transmission { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public static void ConfigureForDb(EntityTypeBuilder<Car> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("Cars");
            entityTypeBuilder.HasKey(x => x.Id);
            entityTypeBuilder.Property(x => x.Brand)
                             .IsRequired()
                             .HasMaxLength(50);
            entityTypeBuilder.Property(x => x.Model)
                             .IsRequired()
                             .HasMaxLength(50);
            entityTypeBuilder.Property(x => x.BodyType)
                             .HasMaxLength(50);
            entityTypeBuilder.Property(x => x.Colour)
                             .HasMaxLength(50);
            entityTypeBuilder.Property(x => x.Mileage)
                             .IsRequired();
            entityTypeBuilder.Property(x => x.Year) 
                             .IsRequired();                             
            entityTypeBuilder.Property(x => x.RentalPricePerDay)
                             .IsRequired()
                             .HasPrecision(18,2);
            entityTypeBuilder.Property(x => x.LicensePlate)
                             .IsRequired()
                             .HasMaxLength(20);
            entityTypeBuilder.HasIndex(x => x.LicensePlate)
                             .IsUnique();
            entityTypeBuilder.Property(x => x.Transmission)
                             .IsRequired()
                             .HasMaxLength(20);
            entityTypeBuilder.Property(x => x.CategoryId)
                             .IsRequired();
            entityTypeBuilder.HasOne(x => x.Category)
                             .WithMany()
                             .HasForeignKey(x => x.CategoryId)
                             .OnDelete(DeleteBehavior.Restrict);//restricts deletion of 
            //any category if there are any cars referencing it.
            
                             

        }
    }
}
