using OdeToFood.Data.DomainClasses;
using System;

namespace OdeToFood.Tests.Builders
{
    internal class RestaurantBuilder
    {
        private readonly Restaurant _restaurant;
        private readonly Random _random;

        public RestaurantBuilder()
        {
            _restaurant = new Restaurant
            {
                Name = Guid.NewGuid().ToString(),
            };

            _random = new Random();
        }

        public RestaurantBuilder WithId()
        {
            _restaurant.Id = _random.Next();
            return this;
        }

        public RestaurantBuilder WithEmptyName()
        {
            _restaurant.Name = null;
            return this;
        }

        public Restaurant Build()
        {
            return _restaurant;
        }
    }
}
