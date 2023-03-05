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

    //Comes here after submitting a new vendor in the New Form 
    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string discription)
    {
      Vendor newvendor = new Vendor(vendorName, discription);
      return RedirectToAction("Index");
    }

    //Comes here after clicking link to add a new vendor in View/Vendor/index.cshtml
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

  }
}