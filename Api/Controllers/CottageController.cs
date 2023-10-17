using Api.Data;
using DataObjects;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CottageController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public CottageController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet("all")]
    public ActionResult GetCottages()
    {
        var cottages = _context.Cottages.ToList();

        return Ok(cottages);
    }

    // [HttpGet("{id:int}")]
    // public async Task<IActionResult> GetCottageAsync(int id)
    // {
    //     var cottage = await _context.Cottages.FindAsync(id);
    //     return Ok(cottage);
    // }

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

    // [HttpPost]
    // public async Task CreateCottageAsync(Cottage input)
    // {
    //     var cottage = new Cottage
    //     {
    //         Title = input.Title,
    //         Description = input.Description,
    //         CostPerDay = input.CostPerDay
    //     };

    //     await _context.Cottages.AddAsync(cottage);
    //     await _context.SaveChangesAsync();
    // }
}