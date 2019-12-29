using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OdeToFood.Data.DomainClasses;

namespace OdeToFood.Data
{
    public class RestaurantReviewDbRepository : IRestaurantReviewsRepository
    {
        private readonly OdeToFoodContext _context;

        public RestaurantReviewDbRepository(OdeToFoodContext context)
        {
            _context = context;
        }

        public async Task<IList<RestaurantReview>> GetAllAsync()
        {
            return await _context.RestaurantReviews.ToListAsync();
        }

        public async Task<RestaurantReview> GetByIdAsync(int id)
        {
            return await _context.RestaurantReviews.FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<List<RestaurantReview>> GetReviewsByRestaurantAsync(int id)
        {
            return await _context.RestaurantReviews.Where(r => r.RestaurantId == id).ToListAsync();
        }

        public async Task<RestaurantReview> AddAsync(RestaurantReview review)
        {
            _context.RestaurantReviews.Add(review);

            await _context.SaveChangesAsync();

            return review;
        }

        public async Task UpdateAsync(RestaurantReview review)
        {
            //Review might not be tracked (attached) by the entity framework -> get original from DB and copy values
            var original = _context.RestaurantReviews.Find(review.Id);
            var entry = _context.Entry(original);
            entry.CurrentValues.SetValues(review);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entityToDelete = _context.RestaurantReviews.Find(id);
            _context.RestaurantReviews.Remove(entityToDelete);

            await _context.SaveChangesAsync();
        }
    }
}
