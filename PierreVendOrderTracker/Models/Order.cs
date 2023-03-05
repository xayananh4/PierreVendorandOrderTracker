using System.Collections.Generic;
using System;

namespace PierreVendOrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public int Price { get; set; }
    DateTime Dt = new DateTime();
    private static List<Order> _instances = new List<Order> { };

    public Order(string title, string description, int price, DateTime dt)
    {
      Title = title;
      Description = description;
      Price = price;
      Dt = dt;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static List<Order> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}