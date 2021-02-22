namespace bookingTrips.Models
{
  public class Cruise : Vacation
  {
    public int Ports { get; set; }


    public Cruise(int ports)
    {
      Ports = ports;
    }
  }
}