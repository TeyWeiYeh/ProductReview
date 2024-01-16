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
    public class BrandsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public BrandsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Brands
        [HttpGet]
        public async Task<IActionResult> GetBrand()
        {
          var brands = await _unitOfWork.Brands.GetAll();
            return Ok(brands);
        }

        // GET: api/Brands/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrand(int id)
        {
            var brand = await _unitOfWork.Brands.Get(q => q.Id == id);
            if (brand == null)
            {
                return NotFound();
            }
            return Ok(brand);
        }

        // PUT: api/Brands/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBrand(int id, Brand brand)
        {
            if (id != brand.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Brands.Update(brand);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await BrandExists(id))
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

        // POST: api/Brands
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Brand>> PostBrand(Brand brand)
        {
            await _unitOfWork.Brands.Insert(brand);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetBrand", new { id = brand.Id }, brand);
        }

        // DELETE: api/Brands/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrand(int id)
        {
           var brand = await _unitOfWork.Brands.Get(q => q.Id == id);
            if (brand == null)
            {
                return NotFound();
            }
            await _unitOfWork.Brands.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> BrandExists(int id)
        {
            var brand = await _unitOfWork.Brands.Get(q => q.Id == id);
            return brand != null;
        }
    }
}
