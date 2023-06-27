using ExtremeBicycle.Extensions;
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

        public static decimal? total = 0;

        //public static List<Product> products { get; set; } = new List<Product>();



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

            var cart = HttpContext.Session.GetCart();

            if (cart != null) {
                // Test
            }

            return View(cart);
        }

        public async Task<IActionResult> Add(int? id) {
            var model = await _context.Products
                .Include(p => p.ProductType)
                .Where(p => p.ProductID == id)
                .FirstOrDefaultAsync();

            if (model == null) {
                return NotFound();
            }

            var cart = HttpContext.Session.GetCart();


            cart.Add(model);

            HttpContext.Session.SetCart(cart);

            if (cart.Count == 0) { 
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
            var cart = HttpContext.Session.GetCart();

            return View(cart);
        }
    }
}
