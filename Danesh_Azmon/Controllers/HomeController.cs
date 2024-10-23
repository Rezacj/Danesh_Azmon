using Danesh_Azmon.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Danesh_Azmon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                // کاربر قبلاً لاگین کرده است، هدایت به داشبورد
                if (User.IsInRole("student"))
                    return RedirectToPage("/Student/Index");
                else
                    return RedirectToPage("/Teacher/Index");
            }

            return View(); // نمایش فرم لاگین در صورتی که کاربر لاگین نشده باشد
           
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
