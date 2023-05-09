namespace CarDeals.Models
{
  public class SUVs : CarLot
  {
    public SUVs(string make, string model, int year, string color, float price)
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