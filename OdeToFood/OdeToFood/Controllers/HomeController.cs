using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OdeToFood.Data;
using OdeToFood.Data.DomainClasses;
using OdeToFood.Data.DomainClasses.ViewModels;
using OdeToFood.Data.Factories;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantsRepository _repos;
        private IReviewsRepository _reviewsRepos;
        private IReviewFactory _reviewFactory;

        public HomeController(IRestaurantsRepository repos, IReviewsRepository reviewRepos, IReviewFactory reviewFactory )
        {
            _repos = repos;
            _reviewsRepos = reviewRepos;
            _reviewFactory = reviewFactory;
        }

        public IActionResult Index()
        {
            var restaurants = _repos.GetAll();
            return View(restaurants);
        }

        [HttpGet("Home/Details/{id}")]
        public async Task<ActionResult> Details(int id)
        {
            RestaurantReviewsViewModel vm = new RestaurantReviewsViewModel();
            vm.Restaurant = _repos.GetById(id);
            vm.Reviews = await _reviewsRepos.GetReviewsByRestaurantAsync(id);
            return View(vm);
        }

        // GET: 
        public IActionResult AddReview(int restaurantId)
        {            
            return View();
        }

        [HttpPost("Home/AddReview/{restaurantId}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddReview(int restaurantId, EditReviewViewModel vm)
        {
            try
            {           
                Review review = _reviewFactory.Create(vm);
                
                var createdReview = await _reviewsRepos.AddAsync(review);
                // TODO: Add insert logic here
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View();
            }
        }

    

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
