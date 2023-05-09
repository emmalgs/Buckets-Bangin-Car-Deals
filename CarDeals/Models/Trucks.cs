namespace CarDeals.Models
{
  public class Trucks : CarLot
  {
    public Trucks(string make, string model, int year, string color, float price)
    {
      Make = make;
      Model = model;
      Year = year;
      Color = color;
      Price = price;
    }
  }
}