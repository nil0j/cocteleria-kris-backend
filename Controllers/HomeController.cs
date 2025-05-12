using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using cocteleria_kris_backend.Models;

namespace cocteleria_kris_backend.Controllers;

public class HomeController : Controller
{
    public JsonResult Index()
    {
        JsonMessage message = new JsonMessage("Error 69");
        return Json(message);
    }

    [Authorize]
    public JsonResult Boniato()
    {
        JsonMessage message = new JsonMessage("Eres un boniato");
        return Json(message);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public JsonResult Error()
    {
        JsonMessage message = new JsonMessage("Not found");
        return Json(message);
    }
}
