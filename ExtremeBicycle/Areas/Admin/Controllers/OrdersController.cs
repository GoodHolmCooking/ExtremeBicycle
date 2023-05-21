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

        //Admin/Orders/cart/ID
        public async Task<IActionResult> Index()
        {
            return NotFound();
        }

        //Admin/Orders/Cart/1002
 
        public async Task<IActionResult> Cart(int? id)
        {

            var model = await _context.AllOrderDetails
                .Include(x => x.Product)
                .Where(x => x.OrderID == id)
                .ToListAsync();
                //.Include(x => x.OrderDetails)
                ////.ThenInclude(x => x.Products)
                //.Where(x => x.OrderID == id)
                //.FirstOrDefaultAsync();

            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        public async Task<IActionResult> Checkout(int? id)
        {
            return View();
        }
    }
}
