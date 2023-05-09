using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CarDeals.Models;

namespace CarDeals.Tests
{  
  [TestClass]
  public class SedansTests : IDisposable
  {
    public void Dispose()
    {
      Sedans.ClearAll();
    }
    [TestMethod]
    public void Sedans_CreatesInstanceofSedans_Sedans()
    {
      Sedans bug = new Sedans("vw", "bug", 1959, "mint", 79600);
      Assert.AreEqual(typeof(Sedans), bug.GetType());
    }

    [TestMethod]
    public void Sedans_AddsSedanToOptions_List()
    {
      Sedans bug = new Sedans("vw", "bug", 1959, "mint", 79600);
      Sedans datsun = new Sedans("nissan", "datsun", 1972, "candy-apple", 5600);
      string expected = "nissan";
      Assert.AreEqual(expected, Sedans.All[1].Make);
    }
  }
}