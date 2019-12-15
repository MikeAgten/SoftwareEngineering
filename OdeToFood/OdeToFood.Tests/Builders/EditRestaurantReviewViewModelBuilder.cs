using OdeToFood.Data.DomainClasses.ViewModels;
using System;

namespace OdeToFood.Tests.Builders
{
    public class EditRestaurantReviewViewModelBuilder
    {
        private readonly Random _random;
        private readonly EditRestaurantReviewViewModel _editReviewViewModel;

        public EditRestaurantReviewViewModelBuilder()
        {
            _random = new Random();

            _editReviewViewModel = new EditRestaurantReviewViewModel
            {
                Rating = _random.Next(),
                Body = Guid.NewGuid().ToString(),
                HorecaId = _random.Next(),
                ReviewerName= Guid.NewGuid().ToString()
            };
        }
        public EditRestaurantReviewViewModel Build()
        {
            return _editReviewViewModel;
        }
    }
}
