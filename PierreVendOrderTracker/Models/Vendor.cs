using System.Collections.Generic;

namespace PierreVendOrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> { };

    public List<Order> Orders { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
  }
}