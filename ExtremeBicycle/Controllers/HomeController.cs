using ExtremeBicycle.Models;
using ExtremeBicycle.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics;

namespace ExtremeBicycle.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;
        private readonly ProductsContext _productContext;
        public HomeController(ILogger<HomeController> logger, ProductsContext productsContext) {
            _logger = logger;
            _productContext = productsContext;
        }

        public IActionResult Index() {
            return View();
        }

        public IActionResult Privacy() {
            return View();
        }
        [Route("login")]
        [ActionName("Login")]
        public IActionResult Login()
        {
            return View();
        }
        [Route("about")]
        [ActionName("About")]
        public IActionResult About()
        {
            return View();
        }
        [Route("contact")]
        [ActionName("Contact")]
        public IActionResult Contact()
        {
            return View();
        }
        [Route("faqs")]
        [ActionName("Faqs")]
        public IActionResult Faqs()
        {
            return View();
        }
        [Route("login")]
        [HttpPost]
        [ActionName("Login")]
        public IActionResult ProccessLogin(LoginRequest model)
        {
            //validate things
            if (ModelState.IsValid)
            {
                if(model.User == "test" && model.Pass == "test")
                {
                    SesionManager.LogIn();
                    
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        [Route("searchResults")]
        public IActionResult Find(string text)
        {
            if(text.IsNullOrEmpty())
            {
               HttpContext.Session.SetString("searched", "");
                var query = _productContext.Products.AsQueryable();
                query = query
                    .Include(r => r.ProductType);
                var searchedProducts = query.ToList();
                return View(searchedProducts);
            }
            else
            {
                HttpContext.Session.SetString("searched", text);
                var query = _productContext.Products.AsQueryable();

                query = query.Where(r => r.ProductName.Contains(text) || r.ProductType.ProductTypeName.Contains(text) || r.Supplier.SupplierName.Contains(text))
                    .Include(r => r.ProductType);
                var searchedProducts = query.ToList();
                //gets the items

                return View(searchedProducts);
            }
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}