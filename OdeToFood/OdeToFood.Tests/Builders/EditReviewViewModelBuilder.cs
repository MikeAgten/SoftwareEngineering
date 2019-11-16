using OdeToFood.Data.DomainClasses.ViewModels;
using System;

namespace OdeToFood.Tests.Builders
{
    public class EditReviewViewModelBuilder
    {
        private readonly Random _random;
        private readonly EditReviewViewModel _editReviewViewModel;

        public EditReviewViewModelBuilder()
        {
            _random = new Random();

            _editReviewViewModel = new EditReviewViewModel
            {
                Rating = _random.Next(),
                Body = Guid.NewGuid().ToString(),
                RestaurantId = _random.Next(),
                ReviewerName= Guid.NewGuid().ToString()
            };
        }
        public EditReviewViewModel Build()
        {
            return _editReviewViewModel;
        }
    }
}
