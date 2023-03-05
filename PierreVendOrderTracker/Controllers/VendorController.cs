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
    public ActionResult Create(int VendorId, string OrderDescription)
    {
      string title = "bread";
      string description = "dist";
      DateTime dt1 = new DateTime();

      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(VendorId);
      Order newOrder = new Order(title, description, 1, dt1);
      foundVendor.AddOrder(newOrder);
      List<Order> VendorOrders = foundVendor.Orders;
      model.Add("Orders", VendorOrders);
      model.Add("Vendor", foundVendor);
      return View("Show", model);
    }





  }
}