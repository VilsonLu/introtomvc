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


        public ActionResult BestReview()
        {
            var bestReview = _reviews.OrderByDescending(r => r.Rating);
            return PartialView("_Reviews", bestReview.First());
        }

        // GET: Reviews
        public ActionResult Index()
        {
            var model = from r in _reviews
                orderby r.Country
                select r;
            return View(model);
        }

        // GET: Reviews/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reviews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reviews/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reviews/Edit/5
        public ActionResult Edit(int id)
        {
            var review = _reviews.Single(x => x.Id == id);
            return View(review);
        }

        // POST: Reviews/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var review = _reviews.Single(x => x.Id == id);
            if (TryUpdateModel(review))
            {
                return RedirectToAction("Index");
            }

            return View(review);

        }

        // GET: Reviews/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reviews/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        static List<RestaurantReviews> _reviews = new List<RestaurantReviews>()
        {
            new RestaurantReviews()
            {
                Id = 1,
                City = "Manila",
                Country = "Philippines",
                Name = "Jollibee",
                Rating = 3
            },
            new RestaurantReviews()
            {
                Id = 2,
                City = "Quezon City",
                Country = "Philippines",
                Name = "KFC",
                Rating = 5
            },
            new RestaurantReviews()
            {
                Id = 3,
                City = "Tagaytay",
                Country = "Philippines",
                Name = "Bag of Beans",
                Rating = 7
            }
        };
    }
}
