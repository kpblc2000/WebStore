using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebStore.Models;

namespace WebStore.Controllers
{
  public class HomeController : Controller
  {

    private static readonly List<Employee> _Employees = new()
    {
      new Employee { Id = 1, FirstName = "f1", LastName = "l1", Patronymic = "p1", YearBirst = 1990 },
      new Employee { Id = 1, FirstName = "f2", LastName = "l2", Patronymic = "p2", YearBirst = 1991 },
      new Employee { Id = 1, FirstName = "f3", LastName = "l3", Patronymic = "p3", YearBirst = 1989 },
    };

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

    public IActionResult Employees()
    {
      return View(_Employees);
    }

  }
}
