using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data.DomainClasses
{
    public class RestaurantReview : Review
    {
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
