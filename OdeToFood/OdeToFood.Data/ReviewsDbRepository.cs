﻿using Microsoft.EntityFrameworkCore;
using OdeToFood.Data.DomainClasses;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Data
{
    public class ReviewsDbRepository : IReviewsRepository
    {
        private readonly OdeToFoodContext _context;

        public ReviewsDbRepository(OdeToFoodContext context)
        {
            _context = context;
        }

        public async Task<IList<Review>> GetAllAsync()
        {
            return await _context.Reviews.ToListAsync();
        }

        public async Task<Review> GetByIdAsync(int id)
        {
            return await _context.Reviews.FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<List<Review>> GetReviewsByRestaurantAsync(int id)
        {
            return await _context.Reviews.Where(r => r.RestaurantId == id).ToListAsync();
        }

        public async Task<Review> AddAsync(Review review)
        {
            _context.Reviews.Add(review);

            await _context.SaveChangesAsync();

            return review;
        }

        public async Task UpdateAsync(Review review)
        {
            //Review might not be tracked (attached) by the entity framework -> get original from DB and copy values
            var original = _context.Reviews.Find(review.Id);
            var entry = _context.Entry(original);
            entry.CurrentValues.SetValues(review);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entityToDelete = _context.Reviews.Find(id);
            _context.Reviews.Remove(entityToDelete);

            await _context.SaveChangesAsync();
        }
    }
}
