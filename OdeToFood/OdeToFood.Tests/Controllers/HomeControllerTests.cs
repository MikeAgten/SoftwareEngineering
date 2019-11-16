using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using OdeToFood.Controllers;
using OdeToFood.Data;
using OdeToFood.Data.DomainClasses;
using OdeToFood.Data.DomainClasses.ViewModels;
using OdeToFood.Data.Factories;
using OdeToFood.Tests.Builders;

namespace OdeToFood.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTests
    {
        private Mock<IRestaurantsRepository> _restaurantsRepoMock;
        private Mock<IReviewsRepository> _reviewsRepoMock;
        private Mock<IReviewFactory> _editReviewVmToReviewFactoryMock;
        private HomeController _controller;
        [SetUp]
        public void Setup()
        {
            _restaurantsRepoMock = new Mock<IRestaurantsRepository>();
            _reviewsRepoMock = new Mock<IReviewsRepository>();
            _editReviewVmToReviewFactoryMock = new Mock<IReviewFactory>();
            _controller = new HomeController(_restaurantsRepoMock.Object, _reviewsRepoMock.Object, _editReviewVmToReviewFactoryMock.Object);
        }
        [Test]
        public void Index_ShouldReturnAListOfRestaurants()
        {
            var restaurants = new List<Restaurant>()
            {
                new RestaurantBuilder().Build()
            };

            _restaurantsRepoMock.Setup(r => r.GetAll()).Returns(restaurants);

            var viewResult = _controller.Index() as ViewResult;

            Assert.That(viewResult, Is.Not.Null);
            Assert.That(viewResult.Model, Is.EquivalentTo(restaurants));
            _restaurantsRepoMock.Verify(r => r.GetAll(), Times.Once);
        }

        [Test]
        public void Details_ShouldReturnDetailsOfRestaurantAndReviews()
        {
            var restaurant = new RestaurantBuilder().WithId().Build() ;
            var reviews = new List<Review>()
            {
                new ReviewBuilder().WithId().Build()
            };

            _restaurantsRepoMock.Setup(r => r.GetById(restaurant.Id)).Returns(restaurant);
            _reviewsRepoMock.Setup(review => review.GetReviewsByRestaurantAsync(restaurant.Id)).ReturnsAsync(() => reviews);
                            
            var viewResult =  _controller.Details(restaurant.Id).Result as ViewResult;

            Assert.That(viewResult, Is.Not.Null);
            RestaurantReviewsViewModel model = viewResult.Model as RestaurantReviewsViewModel;
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Restaurant, Is.EqualTo(restaurant));
            Assert.That(model.Reviews, Is.EquivalentTo(reviews));
            
            _restaurantsRepoMock.Verify(r => r.GetById(restaurant.Id), Times.Once);
            _reviewsRepoMock.Verify(r => r.GetReviewsByRestaurantAsync(restaurant.Id), Times.Once);
        }

        [Test]
        public void AddReview_ShouldAddReviewForRestaurant()
        {
            EditReviewViewModel viewModel = new EditReviewViewModelBuilder().Build();
            Review review = new ReviewBuilder().Build();
            review.RestaurantId = viewModel.RestaurantId;

            _editReviewVmToReviewFactoryMock.Setup(f => f.Create(It.IsAny<EditReviewViewModel>()))
                .Returns(review);

            _reviewsRepoMock.Setup(r => r.AddAsync(It.IsAny<Review>())).ReturnsAsync(review);

    
            var redirectResult = _controller.AddReview(review.RestaurantId, viewModel).Result as RedirectToActionResult;
            
            Assert.That(redirectResult, Is.Not.Null);
            Assert.That(redirectResult.Permanent, Is.False);
            Assert.That(redirectResult.ActionName, Is.EqualTo("Index"));

            _reviewsRepoMock.Verify(r => r.AddAsync(It.IsAny<Review>()), Times.Once);
            _editReviewVmToReviewFactoryMock.Verify(e => e.Create(It.IsAny<EditReviewViewModel>()), Times.Once);
        }

    }

    
}
