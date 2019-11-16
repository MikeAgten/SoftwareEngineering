using OdeToFood.Data.DomainClasses;
using System.Collections.Generic;

namespace OdeToFood.Data
{
    public interface IRestaurantsRepository
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant GetById(int id);
        Restaurant Add(Restaurant restaurant);
        void Update(Restaurant restaurant);
        void Delete(int id);
    }
}
