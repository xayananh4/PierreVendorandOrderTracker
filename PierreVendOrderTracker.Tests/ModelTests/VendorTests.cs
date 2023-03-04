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
  }
}