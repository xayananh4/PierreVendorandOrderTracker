using Microsoft.AspNetCore.Mvc;
using PierreVendOrderTracker.Models;
using System.Collections.Generic;

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

    // This one creates new order within a Vendor 

    [HttpPost("/categories/{categoryId}/items")]
    public ActionResult Create(int categoryId, string itemDescription)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Category foundCategory = Category.Find(categoryId);
      Item newItem = new Item(itemDescription);
      foundCategory.AddItem(newItem);
      List<Item> categoryItems = foundCategory.Items;
      model.Add("items", categoryItems);
      model.Add("category", foundCategory);
      return View("Show", model);
    }



  }
}