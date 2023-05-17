using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExtremeBicycle.Models.Entities {
    public class OrderDetails {
        [Key]
        public int OrderID { get; set; }

        public int ProductID { get; set; }

        public double? UnitPrice { get; set; }

        public int? Quantity { get; set; }

        // navigation properties
        [ForeignKey(nameof(OrderID))]
        public virtual Order? Order { get; set; }

        [ForeignKey(nameof(ProductID))]
        public virtual Product? Product { get; set; }
    }

    public class OrderDetailsConfiguration : IEntityTypeConfiguration<OrderDetails> {
        public void Configure(EntityTypeBuilder<OrderDetails> builder) {
            builder.ToTable("OrdersDetails");
        }
    }
}
