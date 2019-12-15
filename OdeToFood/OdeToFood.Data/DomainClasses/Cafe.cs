using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data.DomainClasses
{
    public class Cafe : Horeca
    {
        public override List<string> FoodList()
        {
            //Call to Cafe's API to retrieve foodlist
            return null;
        }
    }
}
