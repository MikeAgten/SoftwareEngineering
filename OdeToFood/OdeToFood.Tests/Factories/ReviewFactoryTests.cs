using NUnit.Framework;
using OdeToFood.Data.Factories;
using OdeToFood.Tests.Builders;

namespace OdeToFood.Tests.Factories
{
    [TestFixture]
    public class ReviewFactoryTests
    {
        private ReviewFactory _factory;

        [SetUp]
        public void Setup()
        {
            _factory = new ReviewFactory();
        }

        [Test]
        public void Create_ValidReview_CorrectlyMapped()
        {
            //Arrange
            var editReviewVm = new EditReviewViewModelBuilder().Build();
            
            //Act
            var review = _factory.Create(editReviewVm);

            //Assert
            Assert.That(review, Is.Not.Null);
            Assert.That(review.ReviewerName, Is.EqualTo(review.ReviewerName));
            Assert.That(review.Rating, Is.EqualTo(review.Rating));
            Assert.That(review.RestaurantId, Is.EqualTo(review.RestaurantId));
            Assert.That(review.Body, Is.EqualTo(review.Body));
        }
    }
}
