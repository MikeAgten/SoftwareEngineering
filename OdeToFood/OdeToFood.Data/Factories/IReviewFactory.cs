using OdeToFood.Data.DomainClasses;
using OdeToFood.Data.DomainClasses.ViewModels;

namespace OdeToFood.Data.Factories
{
    public interface IReviewFactory
    {
        Review Create(EditReviewViewModel editVm);
    }
}
