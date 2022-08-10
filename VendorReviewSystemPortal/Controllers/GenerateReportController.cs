using Microsoft.AspNetCore.Mvc;
using VendorReviewSystemPortal.Models;

namespace VendorReviewSystemPortal.Controllers
{
    public class GenerateReportController : Controller
    {
        public IActionResult report()
        {
            using (UserContext db = new UserContext())
            {
                TempData["vendors"] = db.Vendors.ToList();
            }
            using (UserContext db = new UserContext())
            {
                TempData["foodies"] = db.Foodies.ToList();
            }
            return View();
        }
    }
}
