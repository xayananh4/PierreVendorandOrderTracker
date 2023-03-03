using ShapeTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace ShapeTracker.Controllers
{
  public class HomeController : Controller
  {





    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/postcard")]
    public ActionResult TriType(int side1, int side2, int side3)
    {
      Triangle myTriangle = new Triangle(side1, side2, side3);
      myTriangle.Side1 = side1;
      myTriangle.Side2 = side2;
      myTriangle.Side3 = side3;

      return View(myTriangle);
    }

  }
}