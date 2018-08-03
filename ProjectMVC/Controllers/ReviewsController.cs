using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public ActionResult Create(int restaurantId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(RestaurantReview review)
        {
            if (ModelState.IsValid)
            {
                _db.Reviews.Add(review);
                _db.SaveChanges();
                return RedirectToAction("Index", new {id = review.RestaurantId});
            }

            return View(review);
        }

        public ActionResult Edit(int id)
        {
            var review = _db.Reviews.Find(id);
            return View(review);
        }

        [HttpPost]
        public ActionResult Edit(RestaurantReview review)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(review).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = review.RestaurantId });
            }

            return View(review);
        }

        protected override void Dispose(bool disposing)
        {
             _db.Dispose();
            base.Dispose(disposing);
        }
    }
}
