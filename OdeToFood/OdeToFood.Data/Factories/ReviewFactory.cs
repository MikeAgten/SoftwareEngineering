using OdeToFood.Data.DomainClasses;
using OdeToFood.Data.DomainClasses.ViewModels;

namespace OdeToFood.Data.Factories
{
    public class ReviewFactory : IReviewFactory
    {
        public Review Create(EditReviewViewModel editVm)
        {
            Review review = new Review();
            review.Body = editVm.Body;
            review.Rating = editVm.Rating;
            review.RestaurantId = editVm.RestaurantId;
            review.ReviewerName = editVm.ReviewerName;
            return review;
        }
    }
}
