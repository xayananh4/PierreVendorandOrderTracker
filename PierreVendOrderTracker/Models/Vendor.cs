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

    public Vendor(string name, string discription)
    {
      Name = name;
      Description = discription;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }
    public static Vendor Find(int searchId)
    {
      return _instances[searchId - 1];
    }


  }
}