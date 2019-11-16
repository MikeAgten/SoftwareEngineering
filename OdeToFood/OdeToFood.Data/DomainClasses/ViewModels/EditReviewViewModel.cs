using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Data.DomainClasses.ViewModels
{
    public class EditReviewViewModel
    {
        [Range(1, 10)]
        public int Rating { get; set; }

        public string Body { get; set; }

        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }

        [Required]
        public string ReviewerName { get; set; }
    }
}
