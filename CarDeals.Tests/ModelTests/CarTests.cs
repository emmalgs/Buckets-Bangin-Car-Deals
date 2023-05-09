using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CarDeals.Models;

namespace CarDeals.Tests
{
  [TestClass]
  public class CarTests
  {
    [TestMethod]
    public void Car_CreatesInstanceofCar_Car()
    {
      Cars bronco = new Cars();
      Assert.AreEqual(typeof(Cars), bronco.GetType());
    }
  }
}