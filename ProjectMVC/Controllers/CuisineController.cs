using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectMVC.Filters;

namespace ProjectMVC.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        // Action is just a public method
        // Any public method that you will add here, they can invoke it through URL
        // ASP.NET will try to look for every possible location to fill up the method (query string, URL configuration, posted)

        [Log]
        public ActionResult Search(string name)
        {
            return Content(name);
        }
    }
}