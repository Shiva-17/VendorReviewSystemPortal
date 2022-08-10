using Microsoft.AspNetCore.Mvc;
using VendorReviewSystemPortal.Models;

namespace VendorReviewSystemPortal.Controllers
{
    public class VendorController : Controller
    {
        public IActionResult VenSignup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult VenSignup(Vendor vn)
        {
            using (UserContext db = new UserContext())
            {
                db.Vendors.Add(vn);
                if (db.SaveChanges() > 0)
                {
                    TempData["status"] = "1";
                    ModelState.Clear();
                }
                else
                {
                    TempData["status"] = "0";
                }
            }
            return View();
        }
        public IActionResult pay()
        {
            using (UserContext db = new UserContext())
            {
                TempData["vendors"] = db.Vendors.ToList();
            }
            return View();
        }

        public IActionResult Getv(string N)
        {
            Vendor vv = new Vendor();

            using (UserContext db = new UserContext())
            {
                vv=db.Vendors.Where(x => x.Name == N).FirstOrDefault();
            }
            return View(vv);
        }

        public IActionResult passVSignup()
        {
            using (UserContext db = new UserContext())
            {
                TempData["vendors"] = db.Vendors.ToList();
            }

            return View();
        }

        public IActionResult Editven(int id)
        {
            Vendor v = new Vendor();
            using (UserContext db = new UserContext())
            {
                v = db.Vendors.Where(x => x.UserID == id).FirstOrDefault();
            }

            return View(v);
        }

        [HttpPost]
        public IActionResult Editven(Vendor ven)
        {

            using (UserContext db = new UserContext())
            {
                var res = db.Vendors.Find(ven.UserID);
                res.Name = ven.Name;
                res.Password = ven.Password;
                res.ConfirmPassword = ven.ConfirmPassword;
                res.EmailID = ven.EmailID;
                res.WebsiteID = ven.WebsiteID;
                res.Location = ven.Location;
                int count = db.SaveChanges();
                if (count > 0)
                {
                    TempData["EditMsg"] = "1";
                    ModelState.Clear();
                }
                else
                {
                    TempData["EditMsg"] = "0";
                }
            }

            return View();
        }


    }
}
