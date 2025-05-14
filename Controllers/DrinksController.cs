using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cocteleria_kris_backend.Models;
using cocteleria_kris_backend.Data;
using Microsoft.AspNetCore.Authorization;

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
            [FromQuery] string? type,
            [FromQuery] string? flavour,
            [FromQuery] bool? orderByPrice,
            [FromQuery] string? name
    )
    {
        if (_context.Drinks == null)
        {
            return StatusCode(400, "Drinks DbSet is not available in the database context.");
        }

        var drinks = _context.Drinks
            .Where(d => !alcoholic.HasValue || d.Alcoholic == alcoholic)
            .Where(d => type == null || d.PrimaryType == type || d.SecondaryType == type)
            .Where(d => name == null || d.Name == null || d.Name.ToLower().Contains(name.ToLower()));

        if (orderByPrice.HasValue)
        {
            drinks = drinks.OrderBy(d => d.Price);
            if (!orderByPrice.Value)
            {
                drinks = drinks.Reverse();
            }
        }

        return Ok(await drinks.ToListAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Drink>> GetDrinkById(int id, bool? related)
    {
        if (related.HasValue)
        {
            var drinks = _context.Drinks;
            return StatusCode(400, "Drinks DbSet is not available in the database context.");
        }

        var drink = await _context.Drinks.FindAsync(id);

        if (drink == null)
        {
            return NotFound();
        }

        return Ok(drink);

    }

    [Authorize]
    [HttpPost]
    public async Task<ActionResult<Drink>> PostDrinkWithFile([FromForm] Drink drink, IFormFile imageFile)
    {
        if (imageFile != null && imageFile.Length > 0)
        {
            var filePath = Path.Combine(Configuration.FileSystemPath, "drinks", imageFile.FileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await imageFile.CopyToAsync(stream);
            }
        }

        if (_context.Drinks == null)
        {
            return Problem("Entity set 'ApplicationDbContext.Drinks' is null.");
        }

        drink.Filename = imageFile!.FileName;
        _context.Drinks.Add(drink);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetDrinkById), new { id = drink.Id }, drink);
    }

    [Authorize]
    [HttpPut("{id}")]
    public async Task<IActionResult> PutDrink(int id, Drink drink)
    {
        if (id != drink.Id)
        {
            return BadRequest();
        }

        _context.Entry(drink).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!DrinkExists(id))
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

    [Authorize]
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteDrink(int id)
    {
        if (_context.Drinks == null)
        {
            return Problem("Entity set 'ApplicationDbContext.Drinks' is null.");
        }
        var drink = await _context.Drinks.FindAsync(id);
        if (drink == null)
        {
            return NotFound();
        }

        _context.Drinks.Remove(drink);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool DrinkExists(int id)
    {
        return (_context.Drinks?.Any(e => e.Id == id)).GetValueOrDefault();
    }
}
