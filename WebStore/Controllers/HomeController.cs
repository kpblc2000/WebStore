using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      //return View();
      //return Content("First Controller Action");
      return View();
    }

    public IActionResult SecondAction()
    {
      return Content("Second Controller Action");
    }
  }
}
