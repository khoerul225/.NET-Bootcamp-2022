using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace DAY09
{
    internal class EmployeeImpl : IEmployee
    {
        public EmployeeImpl()
        {
        }

        public Employee FindEmployeeById(List<Employee> list, int id)
        {
            Employee emps = null;
            foreach (var item in list)
            {
                if (item.EmpId == id)
                {
                    emps = item;
                }

            }
            return emps;
        }

        public List<Employee> FindListRange(List<Employee> list, decimal startForm, decimal endTo)
        {
            var empRange = new List<Employee>();
            foreach (var item in list)
            {
                if (item.TotalSalary>= startForm && item.TotalSalary<= endTo)
                {
                    empRange.Add(item);
                }
            }
            return empRange;
            ///Return berasal dari foreach yang di looping
            ///item adalah roowwwnya misal 
        }

        public Dictionary<Employee, int> GetEmployeeByRole(List<Employee> list)
        {
            throw new NotImplementedException();
        }

        /*        public Dictionary<Employee, int> GetEmployeeByRole(List<Employee> list)
                {
                    {
                        Dictionary<Employee, int> result = new Dictionary<Employee, int>();
                    }
                    //throw new NotImplementedException();
                }*/


        /// Ketika sudah menambahkan hubungan di program selanjutnya ctrl + . (dot) di Employeemp untuk menambahkan interface
        /// 

        public decimal GetTotalSalary<T>(ref List<T> list)
        {
            var total = 0M;
            ///OffTyfe Jika ada yang diirim generic dan kita ingin akses atribut 
            ///sebuah class employee
            foreach (var item in list.OfType<Employee>())
            {
                total += item.TotalSalary;

            }
            return total;
        }

        public List<Employee> InitDataEmployee()
        {
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
            Programmer prog1 = new Programmer(1005, "Fiki", "Fitrotul    ", new DateTime(2022, 06, 12), 5_600_000, "Tegal", 400_000);
            Sales sales1 = new Sales(1006, "Rohman", "Picisan    ", new DateTime(2022, 06, 12), 3_000_000, "Medan", 500_000, 200_000);
            QA qa1 = new QA(1007, "Fiersa", "Beeari    ", new DateTime(2022, 06, 12), 5_600_000, "Tegal", 10_000);


            ///Direct return from without variable
            return new List<Employee> { emp1, emp2, emp3, emp4, emp5, prog1, sales1, qa1 };


            ////Seyelah return Perintah berikutnya diabaikan
            ///

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
            /*//store to list (mempermudah menampilkan menggunakan list)
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

  
            
        }
        public void Showlist<T>(ref List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
        }

    }
}

