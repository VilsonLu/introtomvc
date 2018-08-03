using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectMVC.Models;

namespace ProjectMVC.Controllers
{
    public class ReviewsController : Controller
    {
        private RestaurantDb _db = new RestaurantDb();

        public ActionResult Index([Bind(Prefix="id")]int restaurantId)
        {
            var restaurantReview = _db.Restaurants.Find(restaurantId);
            return View(restaurantReview);
        }

    }
}
