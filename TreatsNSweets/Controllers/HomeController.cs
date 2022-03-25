using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TreatsNSweets.Models;

namespace TreatsNSweets.Controllers
{
    public class HomeController : Controller
    {

      private readonly TreatsNSweetsContext _db;

      public HomeController(TreatsNSweetsContext db)
      {
        _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        var model = _db;
        return View(model);
      }

    }
}