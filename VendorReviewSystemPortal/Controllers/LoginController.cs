using Microsoft.AspNetCore.Mvc;
using VendorReviewSystemPortal.Models;

namespace VendorReviewSystemPortal.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        

        [HttpPost]
        public IActionResult Login(User us)
        {
            using (UserContext db = new UserContext())
            {
                var u = db.Users.Where(x => x.UserID == us.UserID && x.Password == us.Password);
                if (u.Count() > 0)
                {
                    var user = u.FirstOrDefault();

                    HttpContext.Session.SetInt32("role", user.RoleID);

                    return RedirectToAction("Index", "Dashboard");
                    
                }
                else
                {
                    TempData["msg"] = "0";
                }
                
            }
            using (UserContext db = new UserContext())
            {
                var v = db.Vendors.Where(y => y.UserID == us.UserID && y.Password == us.Password);
                if (v.Count() > 0)
                {
                    
                    var ven = v.FirstOrDefault();

                    HttpContext.Session.SetInt32("role", ven.RoleID);
                    

                    return RedirectToAction("Index", "Dashboard");
                    
                }
                else
                {
                    TempData["ven"] = "0";
                }

            }
            using (UserContext db = new UserContext())
            {
                var foos = db.Foodies.Where(z => z.UserID == us.UserID && z.Password == us.Password);
                if (foos.Count() > 0)
                {
                    var foo = foos.FirstOrDefault();

                    HttpContext.Session.SetInt32("role", foo.RoleID);

                    return RedirectToAction("Index", "Dashboard");
                    
                }
                else
                {
                    TempData["foo"] = "0";
                }

            }
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Login");
        }

    }
}
