using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CarDeals.Models;

namespace CarDeals.Tests
{  
  [TestClass]
  public class SUVsTests : IDisposable
  {
    public void Dispose()
    {
      SUVs.ClearAll();
    }
    [TestMethod]
    public void SUVs_CreatesInstanceofSUVs_SUVs()
    {
      SUVs landcruiser = new SUVs("toyota", "landcruiser", 1979, "teal", 38300);
      Assert.AreEqual(typeof(SUVs), landcruiser.GetType());
    }

    [TestMethod]
    public void SUVs_AddsSUVToOptions_List()
    {
      SUVs landcruiser = new SUVs("toyota", "landcruiser", 1979, "teal", 38300);
      SUVs wagoneer = new SUVs("vw", "thing", 1974, "orange", 33400);
      string expected = "vw";
      Assert.AreEqual(expected, SUVs.All[1].Make);
    }
  }
}