using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Core.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PaxCapacity { get; set; }

        public static void ConfigureForDb(EntityTypeBuilder<Category> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("Categories");
            entityTypeBuilder.HasKey(x => x.Id);
            entityTypeBuilder.Property(x => x.Name)
                             .IsRequired()
                             .HasMaxLength(50);
            entityTypeBuilder.Property(x => x.PaxCapacity)
                             .IsRequired();
        }
    }
}
