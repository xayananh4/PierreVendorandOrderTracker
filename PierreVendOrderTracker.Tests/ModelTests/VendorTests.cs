using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreVendOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace PierreVendOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test";
      Vendor newVend = new Vendor(name);

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
      Assert.AreEqual(discription, result);
    }
  }
}