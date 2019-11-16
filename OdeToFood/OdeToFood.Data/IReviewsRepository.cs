using OdeToFood.Data.DomainClasses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OdeToFood.Data
{
    public interface IReviewsRepository
    {
        Task<IList<Review>> GetAllAsync();
        Task<Review> GetByIdAsync(int id);
        Task<List<Review>> GetReviewsByRestaurantAsync(int id);
        Task<Review> AddAsync(Review review);
        Task UpdateAsync(Review review);
        Task DeleteAsync(int id);
    }
}
