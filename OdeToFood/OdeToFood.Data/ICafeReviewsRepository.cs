using System.Collections.Generic;
using System.Threading.Tasks;
using OdeToFood.Data.DomainClasses;

namespace OdeToFood.Data
{
    public interface ICafeReviewsRepository
    {

        Task<IList<CafeReview>> GetAllAsync();
        Task<CafeReview> GetByIdAsync(int id);
        Task<List<CafeReview>> GetReviewsByCafeAsync(int id);
        Task<CafeReview> AddAsync(CafeReview review);
        Task UpdateAsync(CafeReview review);
        Task DeleteAsync(int id);
    }
}