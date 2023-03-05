using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreVendOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace PierreVendOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test", "qwerty");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test";
      Vendor newVend = new Vendor(name, "qwerty");

      //Act
      string result = newVend.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string name = "Test";
      string description = "qwertyuiop";
      Vendor newVend = new Vendor(name, description);

      //Act
      string result = newVend.Description;

      //Assert
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string name = "Test";
      string description = "qwertyuiop";
      Vendor newVendor = new Vendor(name, description);

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string name01 = "starbucks";
      string name02 = "coffee";
      string desc01 = "winco";
      string desc02 = "sodas";
      Vendor newVendor1 = new Vendor(name01, desc01);
      Vendor newVendor2 = new Vendor(name02, desc02);
      List<Vendor> newListOfVendors = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newListOfVendors, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string name01 = "starbucks";
      string name02 = "coffee";
      string desc01 = "winco";
      string desc02 = "sodas";
      Vendor newVendor1 = new Vendor(name01, desc01);
      Vendor newVendor2 = new Vendor(name02, desc02);

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      //Arrange
      string Title1 = "bread";
      DateTime dt1 = new DateTime();
      Order newOrder1 = new Order(Title1, "desc", 1, dt1);

      List<Order> newList = new List<Order> { newOrder1 };
      string name = "starbucks";
      string desc01 = "coffee";
      Vendor newVendor = new Vendor(name,desc01);
      
      newVendor.AddOrder(newOrder1);

      //Act
      List<Order> result = newVendor.Orders;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}