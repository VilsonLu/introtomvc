using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectMVC.Models;

namespace ProjectMVC.Controllers
{
    public class HomeController : Controller
    {

        RestaurantDb _db = new RestaurantDb();

        public ActionResult Index(string searchTerm = null)
        {
            var model = _db.Restaurants.OrderByDescending(r => r.Reviews.Average(x => x.Rating))
                .Where(s => searchTerm == null || s.Name.StartsWith(searchTerm));
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}