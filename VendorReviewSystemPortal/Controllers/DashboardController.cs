using Microsoft.AspNetCore.Mvc;

namespace VendorReviewSystemPortal.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
