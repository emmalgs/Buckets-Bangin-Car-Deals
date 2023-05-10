using Microsoft.AspNetCore.Mvc;
using CarDeals.Models;
using System.Collections.Generic;
using System;

namespace CarDeals.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/carlot")]
    public ActionResult Carlot(string[] car)
    {
      string type = car[0];
      if(type == "trucks")
      {
        Trucks truck = new Trucks(car[1], car[2], int.Parse(car[3]), car[4], int.Parse(car[5]));
        return View("Carlot", truck);
      }
      else if(type == "suvs")
      {
        SUVs suv = new SUVs(car[1], car[2], int.Parse(car[3]), car[4], int.Parse(car[5]));
        return View("Carlot", suv);
      }
      else
      {
        Sedans sedan = new Sedans(car[1], car[2], int.Parse(car[3]), car[4], int.Parse(car[5]));
        return View("Carlot", sedan);
      }
    }
    [HttpGet("/allcars")]
    public ActionResult AllCars()
    {
      return View("Allcars");
    }
  }
}