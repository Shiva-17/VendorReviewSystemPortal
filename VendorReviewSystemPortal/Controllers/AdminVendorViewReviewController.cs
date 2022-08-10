using Microsoft.AspNetCore.Mvc;
using VendorReviewSystemPortal.Models;

namespace VendorReviewSystemPortal.Controllers
{
    public class AdminVendorViewReviewController : Controller
    {
        public IActionResult AVR()
        {
            using (UserContext db = new UserContext())
            {
                TempData["foodiereview"] = db.FoodieReviews.ToList();
            }
            return View();
        }
    }
}
