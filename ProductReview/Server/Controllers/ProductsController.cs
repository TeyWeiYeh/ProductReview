﻿using System;
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
    public class ProductsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;


        //public ProductsController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        public ProductsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Products
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        public async Task<IActionResult> GetProducts()
        {
          //if (_context.Products == null)
          //{
          //    return NotFound();
          //}
          //  return await _context.Products.ToListAsync();
          var products = await _unitOfWork.Products.GetAll(includes: q=>q.Include(x=>x.Brand).Include(x => x.Category));
            return Ok(products);
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Product>> GetProduct(int id)
        public async Task<IActionResult> GetProduct(int id)
        {
          //if (_context.Products == null)
          //{
          //    return NotFound();
          //}
            //var product = await _context.Products.FindAsync(id);
            var product = await _unitOfWork.Products.Get(q => q.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            //return product;
            return Ok(product);
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            //_context.Entry(product).State = EntityState.Modified;
            _unitOfWork.Products.Update(product);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!ProductExists(id))
                if (!await ProductExists(id))
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

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
          //if (_context.Products == null)
          //{
          //    return Problem("Entity set 'ApplicationDbContext.Products'  is null.");
          //}
            //_context.Products.Add(product);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Products.Insert(product);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetProduct", new { id = product.Id }, product);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            //if (_context.Products == null)
            //{
            //    return NotFound();
            //}
            //var product = await _context.Products.FindAsync(id);
            var product = await _unitOfWork.Products.Get(q => q.Id == id);
            if (product == null)
            {
                return NotFound();
            }

			// Get all favourites associated with the product
			var favourites = await _unitOfWork.Favourites.GetAll(f => f.ProductId == id);

			//// Delete all favourites associated with the product
			foreach (var favourite in favourites)
			{
				await _unitOfWork.Favourites.Delete(favourite.Id);
			}

			//_context.Products.Remove(product);
			//await _context.SaveChangesAsync();
			await _unitOfWork.Products.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool ProductExists(int id)
        private async Task<bool> ProductExists(int id)
        {
            //return (_context.Products?.Any(e => e.Id == id)).GetValueOrDefault();
            var product = await _unitOfWork.Products.Get(q => q.Id == id);
            return product != null;
        }
    }
}
