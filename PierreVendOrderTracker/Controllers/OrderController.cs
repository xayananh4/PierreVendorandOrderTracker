using Microsoft.AspNetCore.Mvc;
using PierreVendOrderTracker.Models;

namespace PierreVendOrderTracker.Controllers
{
    public class OrderController : Controller
    {

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int VendorId)
    {
      Vendor Vendor = Vendor.Find(VendorId);
      return View(Vendor);
    }

    }
}