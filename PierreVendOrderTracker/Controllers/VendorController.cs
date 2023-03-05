using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Controllers
{
    public class VendorController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}