namespace bookingTrips.Interfaces
{
  // NOTE public interface, NOT public class
  public interface IPurchasable
  {
    public int Price { get; set; }
    public string Name { get; set; }
  }
}