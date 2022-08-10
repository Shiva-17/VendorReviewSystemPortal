using Microsoft.AspNetCore.Mvc;
using VendorReviewSystemPortal.Models;

namespace VendorReviewSystemPortal.Controllers
{
    public class AdminViewComplaintController : Controller
    {
        public IActionResult adminview()
        {
            using (UserContext db = new UserContext())
            {
                TempData["adminraise"] = db.Complaints.ToList();
            }
            return View();
        }
    }
}
