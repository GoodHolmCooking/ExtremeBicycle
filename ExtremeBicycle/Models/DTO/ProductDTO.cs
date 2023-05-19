using ExtremeBicycle.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExtremeBicycle.Models.DTO {
    public class ProductDTO {
        public ProductsContext Context { get; set; }

        public ProductType? ProductType { get; set; }

        public List<ProductType>? ProductTypes { get; set; }
    }
}
