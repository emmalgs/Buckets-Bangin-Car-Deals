using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CarDeals.Models;

namespace CarDeals.Tests
{  
  [TestClass]
  public class TrucksTests : IDisposable
  {
    public void Dispose()
    {
      Trucks.ClearAll();
    }
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
      string expected = "jeep";
      Assert.AreEqual(expected, Trucks.All[1].Make);
    }
  }
}