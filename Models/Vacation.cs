using System.ComponentModel.DataAnnotations;
using bookingTrips.Interfaces;

namespace bookingTrips.Models
{
  public abstract class Vacation : IPurchasable
  {
    public int Id { get; set; }
    public string Name { get; set; }
    [Required]
    public int Price { get; set; }
    public int LengthDays { get; set; }
    public int FoodCost { get; set; }


    // NOTE the constructor is not needed for a webapi per Mark. Also if there is a constructor on this parent class, than the child items will need something too and it gets mad.

    // public Vacation(string name, int price, int lengthDays, int stops, int foodCost)
    // {
    //   Name = name;
    //   Price = price;
    //   LengthDays = lengthDays;
    //   FoodCost = foodCost;
    // }
  }
}