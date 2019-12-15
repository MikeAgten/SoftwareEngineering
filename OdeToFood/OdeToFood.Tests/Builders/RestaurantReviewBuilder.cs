using OdeToFood.Data.DomainClasses;
using System;

namespace OdeToFood.Tests.Builders
{
    internal class RestaurantReviewBuilder
    {
        private readonly RestaurantReview _review;
        private readonly Random _random;

        public RestaurantReviewBuilder()
        {
            _random = new Random();

            _review = new RestaurantReview
            {
                ReviewerName = Guid.NewGuid().ToString(),
                Rating = _random.Next(1, 6)
            };
        }

        public RestaurantReviewBuilder WithReviewerName(string reviewerName)
        {
            _review.ReviewerName = reviewerName;
            return this;
        }

        public RestaurantReviewBuilder WithId()
        {
            _review.Id = _random.Next();
            return this;
        }

        public RestaurantReview Build()
        {
            return _review;
        }
    }
}
