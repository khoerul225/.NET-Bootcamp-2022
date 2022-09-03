﻿// call class empolyee
using static System.Console;
using DAY09;
using System.Globalization;
bool testing = false;

/*//create object instant , gunakan operator new
Employee emp1 = new Employee();
emp1.EmpId = 1000;
emp1.FirstName = "Khoerul";
emp1.LastName1 = "Mutaqin";
emp1.JoinDate = DateTime.Now;
emp1.BasicSalary = 7_000_000;
emp1.City1 = "Brebes";
emp1.Role = "Programmer";






//create oject employee with parameter constructor
Employee emp2 = new Employee(1001, "Happy", "Asmara    ", new DateTime(2022, 06, 12), 5_000_000, "Semarang", "Sales");
Employee emp3 = new Employee(1002, "Denny", "Caknan    ", new DateTime(2022, 06, 12), 5_000_000, "Madiun", "QA");
Employee emp4 = new Employee(1003, "Juang", "Astrajingga", new DateTime(2022, 06, 12), 5_000_000, "Bandung", "Engineering");
Employee emp5 = new Employee(1004, "Silvia", "Raudha    ", new DateTime(2022, 06, 12), 5_000_000, "Aceh", "Psikologi");

WriteLine("======================29 Agustus 2022===========================================================================================");
WriteLine("===========================OOP==================================================================================================");
WriteLine("================================================================================================================================");

WriteLine(emp1.ToString());
WriteLine(emp2.ToString());
WriteLine(emp3.ToString());
WriteLine(emp4.ToString());
WriteLine(emp5.ToString());
WriteLine();
WriteLine("================================================================================================================================");
WriteLine($"Total employee : {Employee.totalEmployee}");
WriteLine($"total Basic Salary : {Employee.totalBasic.ToString("C", new CultureInfo("Id-ID"))}");
//merubah data salary
emp3.Role = "QA";
emp3.BasicSalary = 9_000_000;
WriteLine("================================================================================================================================");
//Create Object Class Programmer
Programmer prog1 = new Programmer(1005, "Fiki", "Fitrotul    ", new DateTime(2022, 06, 12), 5_600_000, "Tegal", 400_000);
Sales sales1 = new Sales(1006, "Rohman", "Picisan    ", new DateTime(2022, 06, 12), 3_000_000, "Medan", 500_000, 200_000);
QA qa1 = new QA(1007, "Fiersa", "Beeari    ", new DateTime(2022, 06, 12), 5_600_000, "Tegal", 10_000);

//store to list (mempermudah menampilkan menggunakan list)
List<Employee> listEmps = new List<Employee> { emp1, emp2, emp3, emp4, emp5, prog1, sales1, qa1 };

foreach (var item in listEmps)
{
    WriteLine(item.ToString());
}

WriteLine();
WriteLine("================================================================================================================================");
WriteLine($"Total employee : {Employee.totalEmployee}");
WriteLine($"total Basic Salary : {Employee.totalBasic.ToString("C", new CultureInfo("Id-ID"))}");
WriteLine("================================================================================================================================");
*/

WriteLine("==========================Implementasi Interface=========================================================================================");
/// <summary>
/// call Implementation & interface
/// </summary>

IEmployee empinf = new EmployeeImpl();


var ListOfEmps = empinf.InitDataEmployee();
/// cara menampilkan list Emp
empinf.Showlist(ref ListOfEmps);


var emp = empinf.FindEmployeeById(ListOfEmps,1002);
Console.WriteLine($"Found : {emp}");
/// cara menampilkan EMployee by id

var total = empinf.GetTotalSalary(ref ListOfEmps);
Console.WriteLine($"total Salary : {total}"); ///cuma 1 row
/// cara menampilkan total salary

var empSalarRange = empinf.FindListRange(ListOfEmps,2_000_000,4_500_000);
empinf.Showlist(ref empSalarRange); ///lebih dari 1 row / bisa pakai foreach
/// cara menampilkan total salary


Console.ReadLine();



///Buat Koneksi di program
/// buat koneksi di Employeeimpls ctrl + .(dot)
/// Buat display  di program



