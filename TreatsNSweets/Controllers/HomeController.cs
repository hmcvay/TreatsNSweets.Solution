using Microsoft.AspNetCore.Mvc;

namespace TreatsNSweets.Controllers
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