using ExtremeBicycle.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace ExtremeBicycle.Models.Entities {
    public class Order {
        [Key]
        public int OrderID { get; set; }

        public double? OrderAmount { get; set; }

        public int CustomerID { get; set; }

        public int EmployeeID { get; set; }

        public DateTime? OrderDate { get; set; }

        public DateTime? RequiredDate { get; set; }

        public DateTime? ShipDate { get; set; }

        public string? CourierWebsite { get; set; }

        public string? Shipped { get; set; }

        public string? PO { get; set; }

        public bool? PaymentReceived { get; set; }

        // navigation properties

    }

    public class OrderConfiguration : IEntityTypeConfiguration<Order> {
        public void Configure(EntityTypeBuilder<Order> builder) {
            builder.ToTable("Orders");

            builder.Property(x => x.PO)
                .HasColumnName("PO#");
        }
    }
}