using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OdeToFood.Data.DomainClasses;

namespace OdeToFood.Data
{
    public class OdeToFoodContext : IdentityDbContext<User, Role, int>
    {
        public OdeToFoodContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Review> Reviews { get; set; }

        public DbSet<Restaurant> Restaurants { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=OdeToFoodForApi; Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Restaurant>().HasData(new List<Restaurant>
            {
                new Restaurant
                {
                    Id = 1,
                    Name = "Wok palace",
                    City = "Hasselt",
                    Country = "Belgium"
                }
            });
        }
    }
}
