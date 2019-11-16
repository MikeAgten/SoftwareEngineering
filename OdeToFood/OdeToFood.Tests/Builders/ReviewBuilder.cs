using OdeToFood.Data.DomainClasses;
using System;

namespace OdeToFood.Tests.Builders
{
    internal class ReviewBuilder
    {
        private readonly Review _review;
        private readonly Random _random;

        public ReviewBuilder()
        {
            _random = new Random();

            _review = new Review
            {
                ReviewerName = Guid.NewGuid().ToString(),
                Rating = _random.Next(1, 6)
            };
        }

        public ReviewBuilder WithReviewerName(string reviewerName)
        {
            _review.ReviewerName = reviewerName;
            return this;
        }

        public ReviewBuilder WithId()
        {
            _review.Id = _random.Next();
            return this;
        }

        public Review Build()
        {
            return _review;
        }
    }
}
