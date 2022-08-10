using Microsoft.AspNetCore.Mvc;
using VendorReviewSystemPortal.Models;

namespace VendorReviewSystemPortal.Controllers
{
    public class FoodieDetailsController : Controller
    {
        public IActionResult foodet()
        {
            using(UserContext db=new UserContext())
            {
                TempData["foo"] = db.Foodies.ToList();
            }
            return View();
        }
    }
}
