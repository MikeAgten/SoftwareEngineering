using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Data.DomainClasses.ViewModels
{
    public class EditRestaurantViewModel
    {
        public int Name { get; set; }

        public string City { get; set; }

        public int Country { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}