using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cocteleria_kris_backend.Models;
using cocteleria_kris_backend.Data;

namespace cocteleria_kris_backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DrinksController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public DrinksController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Drink>>> GetDrinks(
            [FromQuery] bool? alcoholic,
            [FromQuery] string? tag
    )
    {

        if (_context.Drinks == null)
        {
            return StatusCode(400, "Drinks DbSet is not available in the database context.");
        }

        var drinks = await _context.Drinks
            .Where(d => !alcoholic.HasValue || d.Alcoholic == alcoholic)
            .Where(d => tag == null || d.PrimaryType == tag || d.SecondaryType == tag)
            .ToListAsync();


        return Ok(drinks);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Drink>> GetDrinkById(int id)
    {
        if (_context.Drinks == null)
        {
            return StatusCode(400, "Drinks DbSet is not available in the database context.");
        }

        var drink = await _context.Drinks.FindAsync(id);

        if (drink == null)
        {
            return NotFound();
        }

        return Ok(drink);
    }

    public async Task<ActionResult<IEnumerable<Drink>>> GetAlcoholicDrinks([FromQuery] bool? alcoholic)
    {
        if (_context.Drinks == null)
        {
            return StatusCode(400, "Drinks DbSet is not available in the database context.");
        }

        var nonAlcoholicDrinks = await _context.Drinks
            .Where(d => d.Alcoholic == alcoholic)
            .ToListAsync();

        return Ok(nonAlcoholicDrinks);
    }
}
