using ExtremeBicycle.Models.DTO;
using ExtremeBicycle.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExtremeBicycle.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller {
        private readonly ProductsContext _context;

        public ProductsController(ProductsContext context) {
            _context = context;
        }

        // GET: Admin/Products
        public async Task<IActionResult> Index() {

            return _context.Products != null ?
                        View(await _context.Products
                        .Include(p => p.ProductType)
                        .ToListAsync()) :
                        Problem("Entity set 'ProductsContext.Products' is null.");
        }

        // GET: Admin/Products/1
        public async Task<IActionResult> Type(int? id) {

            var model = new ProductDTO();
            model.Context = _context;
            model.ProductType = await _context.ProductTypes
                .Where(pt => pt.ProductTypeID == id)
                .FirstOrDefaultAsync();

            if (model.ProductType == null) {
                return NotFound();
            }

            return View(model);
        }
    }

}

