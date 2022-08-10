using Microsoft.AspNetCore.Mvc;
using VendorReviewSystemPortal.Models;

namespace VendorReviewSystemPortal.Controllers
{
    public class VendorRequestController : Controller
    {
       public IActionResult venreq()
        {
            using(UserContext db=new UserContext())
            {
                TempData["ven"] = db.Vendors.ToList();
            }
            return View();
        }

        public IActionResult accept()
        {
            using (UserContext db = new UserContext())
            {
                TempData["ven"] = db.Vendors.ToList();
            }

            return View();
        }

        public IActionResult reject(int Id)
        {
     
            Vendor v = new Vendor();
            using (UserContext db = new UserContext())
            {
                v = db.Vendors.Where(x => x.UserID == Id).FirstOrDefault();
                db.Vendors.Remove(v);
                int count = db.SaveChanges();
                if (count > 0)
                {
                    TempData["reject Msg"] = "1";
                    ModelState.Clear();
                }
            }
            using (UserContext db = new UserContext())
            {
                TempData["ven"] = db.Vendors.ToList();
            }
            return View();
        }

    }
}
