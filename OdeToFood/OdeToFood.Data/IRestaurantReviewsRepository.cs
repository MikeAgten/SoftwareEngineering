using System.Collections.Generic;
using System.Threading.Tasks;
using OdeToFood.Data.DomainClasses;

namespace OdeToFood.Data
{
    public interface IRestaurantReviewsRepository
    {

        Task<IList<RestaurantReview>> GetAllAsync();
        Task<RestaurantReview> GetByIdAsync(int id);
        Task<List<RestaurantReview>> GetReviewsByRestaurantAsync(int id);
        Task<RestaurantReview> AddAsync(RestaurantReview review);
        Task UpdateAsync(RestaurantReview review);
        Task DeleteAsync(int id);
    }
}