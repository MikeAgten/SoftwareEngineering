using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Data.DomainClasses
{
    public abstract class Review
    {
        public int Id { get; set; }

        [Range(1, 10)]
        public int Rating { get; set; }

        public string Body { get; set; }

        [Required]
        public string ReviewerName { get; set; }
    }
}
