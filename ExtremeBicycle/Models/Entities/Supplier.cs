using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ExtremeBicycle.Models.Entities {
    public class Supplier {
        [Key]
        public int SupplierID { get; set; }

        public string? SupplierName { get; set; }

        public string? Address1 { get; set; }

        public string? Address2 { get; set; }

        public string? City { get; set; }

        public string? Region { get; set; }

        public string? Country { get; set; }

        public string? PostalCode { get; set; }

        [Phone]
        public string? Phone { get; set; }
    }


    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier> {
        public void Configure(EntityTypeBuilder<Supplier> builder) {
            builder.ToTable("Supplier");
        }
    }
}
