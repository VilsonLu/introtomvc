using ProjectMVC.Models;

namespace ProjectMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProjectMVC.Models.RestaurantDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "ProjectMVC.Models.RestaurantDb";
        }

        protected override void Seed(ProjectMVC.Models.RestaurantDb context)
        {
            context.Restaurants.AddOrUpdate(r => r.Name,
                new Restaurant() { Name = "Jollibee", City = "Manila", Country = "Philippines" },
                new Restaurant() { Name = "Din Tai Fung", City = "Taipei", Country = "Taiwan" },
                new Restaurant() { Name = "Ippudo", City = "Tokyo", Country = "Japan" });
        }
    }
}
