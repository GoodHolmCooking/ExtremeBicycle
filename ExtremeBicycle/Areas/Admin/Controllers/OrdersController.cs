using ExtremeBicycle.Models.DTO;
using ExtremeBicycle.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExtremeBicycle.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrdersController : Controller
    {
        private readonly ProductsContext _context;

        public OrdersController(ProductsContext context)
        {
            _context = context;
        }

        public static List<Product> products { get; set; } = new List<Product>();

        //Admin/Orders/cart/ID
        public async Task<IActionResult> Index()
        {
            return NotFound();
        }

        //Admin/Orders/Cart/1002
 
        public async Task<IActionResult> Cart()
        {

            //var model = await _context.AllOrderDetails
            //    .Include(x => x.Product)
            //    .Where(x => x.OrderID == id)
            //    .ToListAsync();
            //.Include(x => x.OrderDetails)
            ////.ThenInclude(x => x.Products)
            //.Where(x => x.OrderID == id)
            //.FirstOrDefaultAsync();

            ViewBag.Cart = products;

            if (ViewBag.Cart != null) {
                // Test
            }

            return View();
        }

        public async Task<IActionResult> Add(int? id) {
            var model = await _context.Products
                .Include(p => p.ProductType)
                .Where(p => p.ProductID == id)
                .FirstOrDefaultAsync();

            if (model == null) {
                return NotFound();
            }

            products.Add(model);

            if (products.Count == 0) { 
                // Do nothing
            }

            //var model = await _context.AllOrderDetails
            //    .Include(x => x.Product)
            //    .Where(x => x.OrderID == id)
            //    .ToListAsync();
            //.Include(x => x.OrderDetails)
            ////.ThenInclude(x => x.Products)
            //.Where(x => x.OrderID == id)
            //.FirstOrDefaultAsync();

            return RedirectToAction("Cart");
        }

        public async Task<IActionResult> Checkout(int? id)
        {
            return View();
        }
    }
}
