using Northwind.Web.Models;
using System;
using System.Collections.Generic;

namespace Northwind.Web.Repository
{
    public class EmployeeRepository : IEmployee
    {
        public List<Employee> GetAll()
        {
            var listOfEmployee = new List<Employee>() 
            {
                new Employee {Id=1001, Name="Bang Taqin", BirthDate =new System.DateTime (1999,07,03) },
                new Employee {Id=1002, Name="Ka Silvi", BirthDate =new DateTime (2002,04,24) },
                new Employee {Id=1003, Name="Ka Intan", BirthDate =new DateTime (2002,08,11)},
                new Employee {Id=1004, Name="Ka Fiki", BirthDate =new DateTime (1998,01,18)}

            };
            return listOfEmployee;
        }
    }
}
