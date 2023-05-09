using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CarDeals.Models;

namespace CarDeals.Tests
{
  [TestClass]
  public class CarTests
  {
    [TestMethod]
    public void Trucks_CreatesInstanceofTrucks_Trucks()
    {
      Trucks bronco = new Trucks("ford", "bronco", 1975, "blue", 72500);
      Assert.AreEqual(typeof(Trucks), bronco.GetType());
    }

    [TestMethod]
    public void Trucks_AddsTruckToOptions_List()
    {
      Trucks bronco = new Trucks("ford", "bronco", 1975, "blue", 72500);
      Trucks wagoneer = new Trucks("jeep", "wagoneer", 1964, "yellow", 64000);
      Trucks.Options.Add(bronco);
      Trucks.Options.Add(wagoneer);
      string expected = "jeep";
      Assert.AreEqual(expected, Trucks.Options[1].Make);
    }
  }
}