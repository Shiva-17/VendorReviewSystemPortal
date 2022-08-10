using Microsoft.AspNetCore.Mvc;
using VendorReviewSystemPortal.Models;

namespace VendorReviewSystemPortal.Controllers
{
    public class FoodieController : Controller
    {
        public IActionResult FooSignup()
        {
            using (UserContext db = new UserContext())
            {
                TempData["Foodies"] = db.Foodies.ToList();
            }
            return View();
        }

        [HttpPost]
        public IActionResult FooSignup(Foodie Fo)
        {
            using (UserContext db = new UserContext())
            {
                db.Foodies.Add(Fo);
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
        public IActionResult Get(string FN)
        {
            Foodie ff = new Foodie();

            using (UserContext db = new UserContext())
            {
                ff=db.Foodies.Where(x => x.FirstName == FN).FirstOrDefault();
            }
            return View(ff);
        }

        public IActionResult passFSignup()
        {
            using (UserContext db = new UserContext())
            {
                TempData["foo"] = db.Foodies.ToList();
            }

            return View();
        }

        public IActionResult EditFoo(int id)
        {
            Foodie f = new Foodie();
            using (UserContext db=new UserContext())
            {
                f = db.Foodies.Where(x => x.UserID == id).FirstOrDefault();
            }

            return View(f);
        }

        [HttpPost]
        public IActionResult EditFoo(Foodie food)
        {
            
            using (UserContext db = new UserContext())
            {
                var res = db.Foodies.Find(food.UserID);
                res.FirstName = food.FirstName;
                res.LastName = food.LastName;
                res.Password = food.Password;
                res.ConfirmPassword = food.ConfirmPassword;
                res.EmailID = food.EmailID;
                res.DOB = food.DOB;
                res.Age = food.Age;
                res.MobileNo = food.MobileNo;

                int count = db.SaveChanges();
                if(count >0)
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
