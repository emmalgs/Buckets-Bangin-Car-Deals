namespace CarDeals.Models
{
  public class Sedans : CarLot
  {
    public Sedans(string make, string model, int year, string color, float price)
    {
      Make = make;
      Model = model;
      Year = year;
      Color = color;
      Price = price;
      All.Add(this);
    }
  }
}