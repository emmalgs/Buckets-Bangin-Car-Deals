// using System;
using System.Collections.Generic;

namespace CarDeals.Models
{
  public abstract class CarLot
  {
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public float Price { get; set; }
    public static List<CarLot> All { get; set; } = new List<CarLot> {};
    public static void ClearAll()
    {
      All.Clear();
    }
  }
}