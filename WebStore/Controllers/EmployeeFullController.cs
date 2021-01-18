using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore.Controllers
{
  public class EmployeeFullController : Controller
  {

    private Employee employee;

    public IActionResult Index()
    {
      return View();
    }



  }
}
