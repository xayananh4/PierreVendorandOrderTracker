using Microsoft.AspNetCore.Mvc;
using PierreVendOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace PierreVendOrderTracker.Controllers
{
  public class VendorController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    //Comes here after clicking link to add a new vendor in View/Vendor/index.cshtml
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    //Comes here after submitting a new vendor in the New Form 
    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string discription)
    {
      Vendor newvendor = new Vendor(vendorName, discription);
      return RedirectToAction("Index", "Home");
    }

    //Comes here after clicking on vendor link in the index page - clicking on a vendor
    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> VendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", VendorOrders);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderTitle, string orderDescription,
    int orderPrice, DateTime ReleaseDate)
    {
      // string description = "dist";
      // DateTime dt = new DateTime(2018, 7, 24);

      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, ReleaseDate);
      foundVendor.AddOrder(newOrder);
      List<Order> VendorOrders = foundVendor.Orders;
      model.Add("orders", VendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }





  }
}