using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Data.DomainClasses.ViewModels
{
    public abstract class EditReviewViewModel
    {
        [Range(1, 10)]
        public int Rating { get; set; }

        public string Body { get; set; }

        [Required]
        public string ReviewerName { get; set; }
        public int HorecaId { get; set; }
        public virtual Horeca Horeca { get; set; }
    }
}
