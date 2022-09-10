using System;
using Microsoft.AspNetCore.Mvc;
using Northwind.Web.Models;
using System.Collections.Generic;


namespace Northwind.Web.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult ListEmployee()
        {
            //Code Practice
            var listOfEmployee = new List<Employee>() {
                new Employee {Id=1001, Name="Bang Taqin", BirthDate =new DateTime (1999,07,03) },
                new Employee {Id=1002, Name="Ka Silvi", BirthDate =new DateTime (2002,04,24) },
                new Employee {Id=1003, Name="Ka Intan", BirthDate =new DateTime (2002,08,11)}

            };
            return View("ListEmployee", listOfEmployee);
        }
    }
}
