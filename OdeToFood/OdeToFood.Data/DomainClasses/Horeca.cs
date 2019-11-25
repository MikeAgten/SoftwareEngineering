using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data.DomainClasses
{
    public abstract class Horeca
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public abstract List<string> FoodList();
    }
}
