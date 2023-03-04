using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierreVendOrderTracker.Models;
using System;

namespace PierreVendOrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      DateTime dt1 = new DateTime();
      Order newOrder = new Order("starbucks", "desc", 1, dt1);

      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}