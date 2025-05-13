using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; // Needed for ToListAsync()
using cocteleria_kris_backend.Models;
using cocteleria_kris_backend.Data; // Assuming your DbContext is in this namespace

namespace cocteleria_kris_backend.Controllers;

// Designates this class as an API controller
[ApiController]
// Sets the base route for this controller (e.g., /api/drinks)
[Route("api/[controller]")]
// Inherit from ControllerBase for API-specific features
public class DrinksController : ControllerBase
{
    // Private field to hold the database context
    private readonly ApplicationDbContext _context;

    // Constructor to inject the ApplicationDbContext
    public DrinksController(ApplicationDbContext context)
    {
        _context = context;
    }

    // HTTP GET action method to retrieve all drinks
    // This method will respond to GET requests at /api/drinks
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Drink>>> GetDrinks()
    {
        // Check if the Drinks DbSet is null (e.g., context not configured correctly)
        if (_context.Drinks == null)
        {
            // Return a 500 Internal Server Error if the DbSet is not available
            return StatusCode(StatusCodes.Status400BadRequest, "Drinks DbSet is not available in the database context.");
        }

        // Use the DbContext's Drinks DbSet to query all records from the database table.
        // ToListAsync() executes the query asynchronously and returns a List of Drink objects.
        var drinks = await _context.Drinks.ToListAsync();

        // Return the list of drinks. ASP.NET Core automatically serializes
        // the list of Drink objects into a JSON array with a 200 OK status.
        return Ok(drinks); // Using Ok() explicitly returns a 200 OK status
    }

    // The Error action from your original code.
    // In a typical API controller, error handling is often done via middleware
    // or specific ProblemDetails responses rather than a dedicated action.
    // Keeping it here as per your original code structure, but note its typical use case.
    // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    // public IActionResult Error() // Changed return type to IActionResult
    // {
    //     // Assuming JsonMessage is a simple class for JSON responses
    //     // You might want to return a ProblemDetails object for API errors
    //     return StatusCode(StatusCodes.Status404NotFound, new { message = "Not found" });
    // }

    // Note: The original Error action returning JsonResult with JsonMessage
    // might be less common in a pure API context compared to returning
    // specific HTTP status codes and potentially ProblemDetails.
}

// Assuming you have a simple JsonMessage class if needed for other responses,
// but for returning the list of drinks, the framework handles serialization.
// public class JsonMessage
// {
//     public string Message { get; set; }
//     public JsonMessage(string message)
//     {
//         Message = message;
//     }
// }

