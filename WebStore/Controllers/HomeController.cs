using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebStore.Models;

namespace WebStore.Controllers
{
  public class HomeController : Controller
  {

    private static readonly List<Employee> _Employees = new()
    {
      new Employee { Id = 1, FirstName = "f1", LastName = "l1", Patronymic = "p1", YearBirth = 1990, Post = "Post 1", StartWorkYear = 2011 },
      new Employee { Id = 1, FirstName = "f2", LastName = "l2", Patronymic = "p2", YearBirth = 1991, Post = "Chief", StartWorkYear = 2000 },
      new Employee { Id = 1, FirstName = "f3", LastName = "l3", Patronymic = "p3", YearBirth = 1989, Post = "Technical", StartWorkYear = 2019 },
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
