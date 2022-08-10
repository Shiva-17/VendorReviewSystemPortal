using Microsoft.AspNetCore.Mvc;
using VendorReviewSystemPortal.Models;

namespace VendorReviewSystemPortal.Controllers
{
    public class FoodieReviewController : Controller
    {
        public IActionResult foodierev()
        {
            using (UserContext db = new UserContext())
            {
                TempData["vendors"] = db.Vendors.ToList();
            }
            return View();
        }

        [HttpPost]
        public IActionResult foodierev(FoodieReview fr)
        {
            using (UserContext db = new UserContext())
            {
                db.FoodieReviews.Add(fr);
                if (db.SaveChanges() > 0)
                {
                    TempData["foo rev"] = "1";
                    ModelState.Clear();
                }
                else
                {
                    TempData["foo rev"] = "0";
                }
            }
            return View();
        }
    }
}
