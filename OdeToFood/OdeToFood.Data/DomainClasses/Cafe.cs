using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data.DomainClasses
{
    public class Cafe : Horeca
    {
        public override List<string> FoodList()
        {
            return new List<string>() { "food4", "food5", "food6" };
        }
    }
}
