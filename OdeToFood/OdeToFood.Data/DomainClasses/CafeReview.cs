using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data.DomainClasses
{
    public class CafeReview : Review
    {
        public int CafeId { get; set; }
        public virtual Cafe Cafe { get; set; }
    }
}
