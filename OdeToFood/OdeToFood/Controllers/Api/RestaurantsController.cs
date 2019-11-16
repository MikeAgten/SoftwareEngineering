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
    public class RestaurantsController : ControllerBase
    {
            private readonly IRestaurantsRepository _restaurantRepository;


            public RestaurantsController(IRestaurantsRepository restaurantRepository)
            {
                _restaurantRepository = restaurantRepository;
            }

            // GET: api/Restaurants
            [HttpGet]

            public IActionResult GetAll()
            {
                return Ok(_restaurantRepository.GetAll());
            }

            // GET: api/Restaurants/5
            [HttpGet("{id}", Name = "GetRestaurant")]
            public IActionResult GetRestaurant(int id)
            {
                var restaurant = _restaurantRepository.GetById(id);

                if (restaurant == null) return NotFound();

                return Ok(restaurant);
            }

            // POST: api/Restaurants
            [HttpPost]
            public IActionResult Post([FromBody] Restaurant newRestaurant)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                var createdRestaurant = _restaurantRepository.Add(newRestaurant);

                return CreatedAtRoute("DefaultApi", new { controller = "Restaurants", id = createdRestaurant.Id }, createdRestaurant);
            }

            // PUT: api/Restaurants/5
            [HttpPut("{id}")]
            public IActionResult Put(int id, [FromBody] Restaurant restaurant)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                if (id != restaurant.Id)
                {
                    return BadRequest();
                }

                if (_restaurantRepository.GetById(id) == null)
                {
                    return NotFound();
                }

                _restaurantRepository.Update(restaurant);

                return Ok();
            }

            // DELETE: api/ApiWithActions/5
            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                if (_restaurantRepository.GetById(id) == null)
                {
                    return NotFound();
                }

                _restaurantRepository.Delete(id);

                return Ok();
            }
        }
    }
