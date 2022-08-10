using Microsoft.AspNetCore.Mvc;
using VendorReviewSystemPortal.Models;

namespace VendorReviewSystemPortal.Controllers
{
    public class FoodieViewRevController : Controller
    {
        public IActionResult foovierev()
        {
            using (UserContext db = new UserContext())
            {
                TempData["foodiereview"] = db.FoodieReviews.ToList();
            }
            return View();
        }
        public IActionResult edit(int Id)
        {

            FoodieReview r = new FoodieReview();
            using (UserContext db = new UserContext())
            {
                r = db.FoodieReviews.Where(x => x.FoodieUserID == Id).FirstOrDefault();
               
            }
            return View(r);
        }

        [HttpPost]
        public IActionResult edit(FoodieReview fr)
        {

            using (UserContext db = new UserContext())
            {
                var res = db.FoodieReviews.Find(fr.FoodieUserID);
                res.FoodieName = fr.FoodieName;
                res.VendorUserID = fr.VendorUserID;
                res.VendorName = fr.VendorName;
                res.VendorLocation = fr.VendorLocation;
                res.FoodiesReview = fr.FoodiesReview;
                res.FoodieRating = fr.FoodieRating;
                int count = db.SaveChanges();
                if (count > 0)
                {
                    TempData["Edit rev"] = "1";
                    ModelState.Clear();
                }
                else
                {
                    TempData["Edit rev"] = "0";
                }
            }

            return View();
        }

        public IActionResult deletefoo(int Id)
        {
            FoodieReview fr = new FoodieReview();
            using (UserContext db = new UserContext())
            {
                fr = db.FoodieReviews.Where(x => x.FoodieUserID == Id).FirstOrDefault();
                db.FoodieReviews.Remove(fr);
                int count = db.SaveChanges();
                if (count > 0)
                {
                    TempData["Delete review"] = "1";
                    ModelState.Clear();
                }
            }
            using (UserContext db = new UserContext())
            {
                TempData["foodiereview"] = db.FoodieReviews.ToList();
            }

            return View();
        }
    }
}
