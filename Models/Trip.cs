namespace bookingTrips.Models
{
  public class Trip : Vacation
  {
    public int Miles { get; set; }


    public Trip(int miles)
    {
      Miles = miles;
    }
  }
}