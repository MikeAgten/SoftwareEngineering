using System.Collections.Generic;

namespace OdeToFood.Data.DomainClasses
{
    public class Restaurant : Horeca
    {
        public override List<string> FoodList()
        {
            //Call to Restaurant's API to retrieve foodlist
            return null;
        }
    }
}
