using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExtremeBicycle.Models.Entities { 
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        public string? ProductName { get; set; }

        public string? Color { get; set; }

        public string? Size { get; set; }

        public string? Gender { get; set; }

        public decimal? PriceSRP { get; set; }

        public int ProductTypeID { get; set; }

        public string? ProductClass { get; set; }

        public int SupplierID { get; set; }

        // navigation properties
        [ForeignKey(nameof(ProductTypeID))]
        public virtual ProductType? ProductType { get; set; }

        [ForeignKey(nameof(SupplierID))]
        public virtual Supplier? Supplier { get; set; }
    }

    public class ProductConfiguration : IEntityTypeConfiguration<Product> {
        public void Configure(EntityTypeBuilder<Product> builder) {
            builder.ToTable("Product");
        }
    }
}
