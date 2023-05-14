using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.ComponentModel.DataAnnotations;

namespace ExtremeBicycle.Models.Entities {
    public class ProductType {
        [Key]
        public int ProuctTypeID { get; set; }

        public string? ProductTypeName { get; set; }

        public string? Description { get; set; }

        // Image type in DB. No idea what that translates to.
        public string? Picture { get; set; }
    }

    public class ProductTypeConfiguration : IEntityTypeConfiguration<ProductType> {
        public void Configure(EntityTypeBuilder<ProductType> builder) {
            builder.ToTable("ProductType");
        }
    }
}

