using Microsoft.AspNetCore.Mvc;

namespace SillyStringz.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}