using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OdeToFood.Data.DomainClasses;

namespace OdeToFood.Data
{
    public class CafeReviewDbRepository : ICafeReviewsRepository
    {
        private readonly OdeToFoodContext _context;

        public CafeReviewDbRepository(OdeToFoodContext context)
        {
            _context = context;
        }

        public async Task<IList<CafeReview>> GetAllAsync()
        {
            return await _context.CafeReviews.ToListAsync();
        }

        public async Task<CafeReview> GetByIdAsync(int id)
        {
            return await _context.CafeReviews.FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<List<CafeReview>> GetReviewsByCafeAsync(int id)
        {
            return await _context.CafeReviews.Where(r => r.CafeId == id).ToListAsync();
        }

        public async Task<CafeReview> AddAsync(CafeReview review)
        {
            _context.CafeReviews.Add(review);

            await _context.SaveChangesAsync();

            return review;
        }

        public async Task UpdateAsync(CafeReview review)
        {
            //Review might not be tracked (attached) by the entity framework -> get original from DB and copy values
            var original = _context.CafeReviews.Find(review.Id);
            var entry = _context.Entry(original);
            entry.CurrentValues.SetValues(review);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entityToDelete = _context.CafeReviews.Find(id);
            _context.CafeReviews.Remove(entityToDelete);

            await _context.SaveChangesAsync();
        }
    }
}
