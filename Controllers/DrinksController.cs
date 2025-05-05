using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using cocteleria_kris_backend.Models;

namespace cocteleria_kris_backend.Controllers;

public class DrinksController : Controller
{
    public JsonResult Index()
    {
        JsonMessage message = new JsonMessage("List of drinks");
        return Json(message);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public JsonResult Error()
    {
        JsonMessage message = new JsonMessage("Not found");
        return Json(message);
    }
}
