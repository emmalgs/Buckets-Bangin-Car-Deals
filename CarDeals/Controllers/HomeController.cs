using Microsoft.AspNetCore.Mvc;
// using CarDeals.Models;
// using System.Collections.Generic;

namespace CarDeals.Controllers
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