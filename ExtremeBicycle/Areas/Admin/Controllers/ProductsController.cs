using ExtremeBicycle.Extensions;
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

        // This page shouldn't technically be accessed, but I don't know if removing the index breaks anything
        public async Task<IActionResult> Index() {

            return _context.Products != null ?
                        View(await _context.Products
                        .Include(p => p.ProductType)
                        .ToListAsync()) :
                        Problem("Entity set 'ProductsContext.Products' is null.");
        }

        // Admin/Products/Type/1
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

        // Admin/Products/Bikes
        public async Task<IActionResult> Bikes() {

            var model = await _context.Products
                .Include(p => p.ProductType)
                .Where(pt => pt.ProductTypeID == 1 || pt.ProductTypeID == 2 || pt.ProductTypeID == 3) 
                .ToListAsync();

            if (model == null) {
                return NotFound();
            }

            return View(model);
        }

        // GET: Admin/Products/Details/1101
        public async Task<IActionResult> Details(int? id) {

            var product = await _context.Products
                .Where(p => p.ProductID == id)
                .Include(p => p.ProductType)
                .FirstOrDefaultAsync();

            if (product == null) {
                return NotFound();
            }

            ProductDTO model = new ProductDTO();
            model.Product = product;

            return View(model);
        }

        public async Task<IActionResult> Confirmation(int? id)
        {
            var confirmation = HttpContext.Session.GetCart();
            //var demo = HttpContext.Session.GetString("test");

            //ConfirmationDTO dto = new ConfirmationDTO();
            //dto.test = demo;
            //dto.cart = confirmation;

            return View(confirmation);
        }
    }

}

