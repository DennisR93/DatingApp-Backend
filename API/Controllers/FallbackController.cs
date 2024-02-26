using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class FallbackController : Controller
{
    public ActionResult Index()
    {
        return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), "root", "index.html"), "text/HTML");
        //NEED TO CHANGE "root" to real DIRECTORY!
    }
}