using OdeToFood.Data.DomainClasses;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data
{
    public class RestaurantDbRepository : IRestaurantsRepository
    {
        private readonly OdeToFoodContext _context;

        public RestaurantDbRepository(OdeToFoodContext context)
        {
            _context = context;
        }

        public Restaurant Add(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);

            _context.SaveChanges();

            return restaurant;
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _context.Restaurants.ToList();
        }

        public Restaurant GetById(int id)
        {
            return _context.Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public void Update(Restaurant restaurant)
        {
            //Restaurant might not be tracked (attached) by the entity framework -> get original from DB and copy values
            var original = _context.Restaurants.Find(restaurant.Id);
            var entry = _context.Entry(original);
            entry.CurrentValues.SetValues(restaurant);

            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entityToDelete = _context.Restaurants.Find(id);
            _context.Restaurants.Remove(entityToDelete);

            _context.SaveChanges();
        }
    }
}
