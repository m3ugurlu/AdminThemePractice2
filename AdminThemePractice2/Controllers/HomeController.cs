using Microsoft.AspNetCore.Mvc;

namespace AdminLTEIntegration.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            // Örnek veri seti
            ViewBag.TotalUsers = 1200;
            ViewBag.TotalSales = 45000;
            ViewBag.TotalOrders = 350;
            ViewBag.PendingTasks = 15;

            return View();
        }
        public IActionResult ProductList()
        {
            return View();
        }
    }
}
