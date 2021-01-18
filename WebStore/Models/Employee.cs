using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
  public class Employee
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Patronymic { get; set; }
    public int YearBirth { get; set; }
    public int StartWorkYear { get; set; }
    public string Post { get; set; }
    public string FullName => $"{LastName} {FirstName} {Patronymic}";
    public int Age => DateTime.Now.Year - YearBirth;
  }
}
