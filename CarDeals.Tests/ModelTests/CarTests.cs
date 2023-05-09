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
      Trucks.Options.Add(bronco);
      string expected = "ford";
      Assert.AreEqual(expected, Trucks.Options[0].Make);
    }
  }
}