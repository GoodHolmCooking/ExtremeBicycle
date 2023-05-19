using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.ComponentModel.DataAnnotations;

namespace ExtremeBicycle.Models.Entities {
    public class ProductType {
        [Key]
        public int ProductTypeID { get; set; }

        public string? ProductTypeName { get; set; }

        public string? Description { get; set; }

        public byte[]? Picture { get; set; }
    }

    public class ProductTypeConfiguration : IEntityTypeConfiguration<ProductType> {
        public void Configure(EntityTypeBuilder<ProductType> builder) {
            builder.ToTable("ProductType");
        }
    }
}

