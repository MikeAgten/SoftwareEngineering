﻿using System.Collections.Generic;

namespace OdeToFood.Data.DomainClasses.ViewModels
{
    public class RestaurantReviewsViewModel
    {
        public Restaurant Restaurant { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
