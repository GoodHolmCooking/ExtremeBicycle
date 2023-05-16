using ExtremeBicycle.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExtremeBicycle.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
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






        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}