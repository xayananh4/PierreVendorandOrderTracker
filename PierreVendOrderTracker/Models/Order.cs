using System.Collections.Generic;

namespace PierreVendOrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public int Price { get; }
    DateTime date = new DateTime(); 
  }
}