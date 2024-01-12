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
    public class LinksController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public LinksController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Links
        [HttpGet]
        public async Task<IActionResult> GetLinks()
        {
          var links = await _unitOfWork.Links.GetAll();
            return Ok(links);
        }

        // GET: api/Links/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Link>> GetLink(int id)
        {
            var link = await _unitOfWork.Links.Get(q => q.Id == id);
          if (link == null)
          {
              return NotFound();
          }

            return Ok(link);
        }

        // PUT: api/Links/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLink(int id, Link link)
        {
            if (id != link.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Links.Update(link);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await LinkExists(id))
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

        // POST: api/Links
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Link>> PostLink(Link link)
        {
          await _unitOfWork.Links.Insert(link);
          await _unitOfWork.Save(HttpContext);

          return CreatedAtAction("GetLink", new { id = link.Id }, link);
        }

        // DELETE: api/Links/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLink(int id)
        {
            var link = await _unitOfWork.Links.Get(q => q.Id == id);
            if (link == null)
            {
                return NotFound();
            }
            await _unitOfWork.Links.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> LinkExists(int id)
        {
            var link = await _unitOfWork.Links.Get(q => q.Id == id);
            return link != null;
        }
    }
}
