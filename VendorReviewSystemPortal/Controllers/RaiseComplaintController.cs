using Microsoft.AspNetCore.Mvc;
using VendorReviewSystemPortal.Models;

namespace VendorReviewSystemPortal.Controllers
{
    public class RaiseComplaintController : Controller
    {
        public IActionResult raise()
        {
            using (UserContext db = new UserContext())
            {
                TempData["foodiereview"] = db.FoodieReviews.ToList();
            }
            return View();
        }

        public IActionResult com()
        {
            return View();
        }

        [HttpPost]
        public IActionResult com(Complaint c)
        {
            using (UserContext db = new UserContext())
            {
                db.Complaints.Add(c);
                if (db.SaveChanges() > 0)
                {
                    TempData["com"] = "1";
                    ModelState.Clear();
                }
                else
                {
                    TempData["com"] = "0";
                }
            }
            return View();
        }
    }
}
