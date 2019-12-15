using OdeToFood.Data.DomainClasses;
using OdeToFood.Data.DomainClasses.ViewModels;

namespace OdeToFood.Data.Factories
{
    public class ReviewFactory : IReviewFactory
    {
        public Review Create(EditReviewViewModel editVm)
        {
            Review review;


            if (editVm.GetType() == typeof(EditRestaurantReviewViewModel))
            {
                review = new RestaurantReview
                {
                    Body = editVm.Body,
                    Rating = editVm.Rating,
                    ReviewerName = editVm.ReviewerName,
                    RestaurantId = editVm.HorecaId
                };

            }
            else
            {
                review = new CafeReview
                {
                    Body = editVm.Body,
                    Rating = editVm.Rating,
                    ReviewerName = editVm.ReviewerName,
                    CafeId = editVm.HorecaId
                };
            }

            return review;

        }
    }
}
