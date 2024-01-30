using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductReview.Server.Data;
using ProductReview.Server.IRepository;
using ProductReview.Shared.Domain;

namespace ProductReview.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavouritesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public FavouritesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Favourites
        [HttpGet]
        public async Task<IActionResult> GetFavourites()
        {
          var favourites = await _unitOfWork.Favourites.GetAll(includes: q => q.Include(x => x.Product).Include(x => x.Brand).Include(x => x.Category));
            return Ok(favourites);
        }

        // GET: api/Favourites/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Favourite>> GetFavourite(int id)
        {
          var favourite = await _unitOfWork.Favourites.Get(q => q.Id == id);

            if (favourite == null)
            {
                return NotFound();
            }

            return Ok(favourite);
        }

        // PUT: api/Favourites/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFavourite(int id, Favourite favourite)
        {
            if (id != favourite.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Favourites.Update(favourite);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await FavouriteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Favourites
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Favourite>> PostFavourite(Favourite favourite)
        {

			// This is done by querying the Favourites repository with a condition that matches the ProductId
			var existingFavourite = await _unitOfWork.Favourites.Get(q => q.ProductId == favourite.ProductId);

			// If the product is already in the favorites (i.e., existingFavourite is not null)
			if (existingFavourite != null)
			{
				// This informs the client that the product is already in the favorites
				return Conflict(new { message = "Product is already in favourites" });
			}

			await _unitOfWork.Favourites.Insert(favourite);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetFavourite", new { id = favourite.Id }, favourite);
        }

        // DELETE: api/Favourites/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFavourite(int id)
        {
            var favourite = await _unitOfWork.Favourites.Get(q => q.Id == id);
            if (favourite == null)
            {
                return NotFound();
            }
            await _unitOfWork.Favourites.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> FavouriteExists(int id)
        {
            var favourite = await _unitOfWork.Favourites.Get(q => q.Id == id);
            return favourite != null;
        }
    }
}
