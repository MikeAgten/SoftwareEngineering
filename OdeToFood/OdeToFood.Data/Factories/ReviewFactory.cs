using OdeToFood.Data.DomainClasses;
using OdeToFood.Data.DomainClasses.ViewModels;

namespace OdeToFood.Data.Factories
{
    public class ReviewFactory : IReviewFactory
    {
        public Review Create(EditReviewViewModel editVm)
        {
<<<<<<< HEAD
            Review review = null;
=======
            Review review;

>>>>>>> 29f786c762c6c3942826b06e9227fea83a2c2ff4

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
<<<<<<< HEAD
            else if(editVm.GetType() == typeof(EditCafeReviewViewModel))
=======
            else
>>>>>>> 29f786c762c6c3942826b06e9227fea83a2c2ff4
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
