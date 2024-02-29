using Api.Data;
using SharedLibrary.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CottageController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public CottageController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet("all")]
    public async Task<ActionResult<List<Cottage>>> GetCottages()
    {
        var cottages = await _context.Cottages.ToListAsync();

        if (cottages is null || cottages.Count == 0)
        {
            return NoContent();
        }

        return Ok(cottages);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Cottage>> GetCottage(int id)
    {
        var cottage = await _context.Cottages.FindAsync(id);
        
        if (cottage is null)
        {
            return NotFound(id);
        }
        
        return Ok(cottage);
    }

    [HttpPut("")]
    public async Task<ActionResult<List<Cottage>>> UpdateCottage(Cottage cottage)
    {
        var cottageUpdate = await _context.Cottages.FindAsync(cottage.Id);
        if (cottageUpdate == null)
        {
            return NotFound();
        }

        cottageUpdate.Title = cottage.Title;
        cottageUpdate.Description = cottage.Description;
        cottageUpdate.CostPerDay = cottage.CostPerDay;
        cottageUpdate.PictureUrl = cottage.PictureUrl;
        cottageUpdate.Rooms = cottage.Rooms;
        cottageUpdate.IsElectricity = cottage.IsElectricity;
        cottageUpdate.IsSauna = cottage.IsSauna;

        await _context.SaveChangesAsync();
        return Ok(await _context.Cottages.ToListAsync());
    }

    [HttpPost]
    public async Task<ActionResult<List<Cottage>>> CreateCottage(Cottage newCottage)
    {
        _context.Cottages.Add(newCottage);
        await _context.SaveChangesAsync();

        return Ok(await _context.Cottages.ToListAsync());
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult<int>> DeleteCottage(int id)
    {
        var cottage = await _context.Cottages.FindAsync(id);
        if (cottage == null)
        {
            return NotFound(id);
        }
        
        _context.Cottages.Remove(cottage);
        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpGet("{id:int}/Reservations")]
    public async Task<ActionResult<Reservation>> GetReservations(int id)
    {
        var cottage = await _context.Cottages.FirstOrDefaultAsync(c => c.Id == id);
        
        if (cottage is null)
        {
            return NotFound(id);
        }
        
        var reservations = cottage.Reservations;

        if (reservations.Count > 0 || reservations is not null)
        {
            return Ok(reservations);
        }
        else 
        {
            return NotFound(id);
        }
    }
}