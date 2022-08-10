using Microsoft.AspNetCore.Mvc;
using VendorReviewSystemPortal.Models;

namespace VendorReviewSystemPortal.Controllers
{
    public class VendorDetailsController : Controller
    {
        public IActionResult vendet()
        {
            using (UserContext db = new UserContext())
            {
                TempData["vend"] = db.Vendors.ToList();
            }
            return View();
        }
        public IActionResult activate()
        {
            using (UserContext db = new UserContext())
            {
                TempData["vend"] = db.Vendors.ToList();
            }
            return View();
        }
        public IActionResult deactivate(int Id)
        {
         
            Vendor vvv = new Vendor();
            using (UserContext db = new UserContext())
            {
                vvv = db.Vendors.Where(x => x.UserID == Id).FirstOrDefault();
                db.Vendors.Remove(vvv);
                int count = db.SaveChanges();
                if (count > 0)
                {
                    TempData["deactivate Msg"] = "1";
                    ModelState.Clear();
                }
            }
            using (UserContext db = new UserContext())
            {
                TempData["vend"] = db.Vendors.ToList();
            }
            return View();
        }
        public IActionResult delete(int Id)
        {
            Vendor vv = new Vendor();
            using (UserContext db = new UserContext())
            {
                vv = db.Vendors.Where(x => x.UserID == Id).FirstOrDefault();
                db.Vendors.Remove(vv);
                int count = db.SaveChanges();
                if (count > 0)
                {
                    TempData["DeleteMsg"] = "1";
                    ModelState.Clear();
                }
            }
            using (UserContext db = new UserContext())
            {
                TempData["vend"] = db.Vendors.ToList();
            }
            return View();
        }
    }
}
