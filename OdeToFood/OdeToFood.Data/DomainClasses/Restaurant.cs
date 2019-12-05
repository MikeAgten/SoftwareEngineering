using System.Collections.Generic;

namespace OdeToFood.Data.DomainClasses
{
    public class Restaurant : Horeca
    {
        public override List<string> FoodList()
        {
            return new List<string>() { "food1", "food2", "food3"};
        }
    }
}
