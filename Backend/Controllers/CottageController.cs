using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Backend.Data;
using Microsoft.AspNetCore.Mvc;
using DataObjects;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CottageController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CottageController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("all")]
        public IEnumerable<Cottage> GetCottages()
        {
            var cottages = _context.Cottages.ToList();

            return cottages;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCottageAsync(int id)
        {
            var cottage = await _context.Cottages.FindAsync(id);
            return Ok(cottage);
        }

        // [HttpPut]
        // public async Task<IActionResult> UpdateCottageAsync(int id, Cottage cottage)
        // {
        //     var c = _context.Cottages.Find(id);
        //     if (c == null)
        //     {
        //         return BadRequest();
        //     }

        //     _context.Cottages.Update(cottage);
        //     return Ok();
        // }

        [HttpPost]
        public async Task CreateCottageAsync(Cottage input)
        {
            var cottage = new Cottage
            {
                Title = input.Title,
                Description = input.Description,
                CostPerDay = input.CostPerDay
            };

            await _context.Cottages.AddAsync(cottage);
            await _context.SaveChangesAsync();
        }
    }
}