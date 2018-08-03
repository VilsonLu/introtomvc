using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectMVC.Models
{
    public class RestaurantDb : DbContext
    {

        public RestaurantDb() : base("name=DefaultConnection")
        {
                
        }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantReview> Reviews { get; set; }
    }
}