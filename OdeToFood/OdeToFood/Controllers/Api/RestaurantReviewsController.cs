﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OdeToFood.Data;
using OdeToFood.Data.DomainClasses;

namespace OdeToFood.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes =
     JwtBearerDefaults.AuthenticationScheme)]
    public class RestaurantReviewsController : ControllerBase
    {
        private readonly IRestaurantReviewsRepository _reviewRepository;

        public RestaurantReviewsController(IRestaurantReviewsRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        // GET: api/Reviews
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _reviewRepository.GetAllAsync());
        }

        // GET: api/Reviews/5
        [HttpGet("{id}", Name = "GetReviews")]
        public async Task<IActionResult> Get(int id)
        {
            var review = await _reviewRepository.GetByIdAsync(id);

            if (review == null) return NotFound();

            return Ok(review);
        }

        // POST: api/Reviews
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RestaurantReview newReview)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var createdReview = await _reviewRepository.AddAsync(newReview);

            return CreatedAtRoute(routeName: "GetReviews", routeValues: new { controller = "RestaurantReviews", id = createdReview.Id }, value: createdReview);
        }

        // PUT: api/Reviews/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] RestaurantReview review)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (id != review.Id)
            {
                return BadRequest();
            }

            if (await _reviewRepository.GetByIdAsync(id) == null)
            {
                return NotFound();
            }

            await _reviewRepository.UpdateAsync(review);

            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (await _reviewRepository.GetByIdAsync(id) == null)
            {
                return NotFound();
            }

            await _reviewRepository.DeleteAsync(id);

            return Ok();
        }
    }
}
