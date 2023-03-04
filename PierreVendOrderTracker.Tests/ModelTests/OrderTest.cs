using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierreVendOrderTracker.Models;
using System;

namespace PierreVendOrderTracker.Tests
{
  [TestClass]
  public class OrderTests: IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      DateTime dt1 = new DateTime();
      Order newOrder = new Order("starbucks", "desc", 1, dt1);

      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string Title = "bread";

      DateTime dt1 = new DateTime();
      Order newOrder = new Order("bread", "desc", 1, dt1);
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(Title, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      //Arrange
      string Title = "bread";

      DateTime dt1 = new DateTime();
      Order newOrder = new Order("bread", "desc", 1, dt1);

      //Act
      string updatedTitle = "pastry";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(updatedTitle, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}