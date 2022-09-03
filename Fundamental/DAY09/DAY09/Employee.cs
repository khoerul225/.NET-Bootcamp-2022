using System;
using static System.Console;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY09
{
    internal class Employee
    {
        //instant variable = sudah di create objeknya
        private int empId;
        private string firstName;
        private string LastName;
        private DateTime joinDate;
        private Decimal basicSalary;
        private string City;
        private string role;
        private decimal totalSalary;


        //static variable
        public static decimal totalBasic = 0M;
        public static int totalEmployee = 0;
        public Employee()
        {
            totalEmployee++;
            totalBasic += this.basicSalary;
            this.TotalSalary = this.basicSalary;
        }

        //constructor parameter
        public Employee(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary, string City)
        {
            this.empId = empId; // pake random // new Random
            this.firstName = firstName;
            this.LastName = lastName;
            this.joinDate = joinDate;
            this.basicSalary = basicSalary;
            this.City = City;
            totalEmployee++;
            totalBasic += this.basicSalary;
            this.TotalSalary = this.basicSalary;
        }

        public Employee(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary, string city, string role) : this(empId, firstName, lastName, joinDate, basicSalary, city)
        {
            this.role = role;
        }


        public override string? ToString()
        {
            return $"Employee = {this.empId}|Nama : {this.firstName} {this.LastName}| Date Join : {this.joinDate}| role : {this.role}| Basic Salary : {this.basicSalary.ToString("C", new CultureInfo("Id-ID"))}\n";
            Console.WriteLine();
        }

        private decimal GetTotalSalary()
        {
            return this.basicSalary;
        }

        //GetSet / Getter Setter
        public int EmpId { get => empId; set => empId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public DateTime JoinDate { get => joinDate; set => joinDate = value; }

        public decimal BasicSalary
        {
            get => basicSalary;
            set
            {
                basicSalary = value;
                totalSalary = basicSalary;
            }

        }

        public static void No1()
        {
            Programmer prog9 = new Programmer(120, "Anton", "Pratama    ", new DateTime(2015, 03, 13), 6_000_000, "Tegal", 500_000);
            Programmer prog10 = new Programmer(121, "Budi", "Junaedi    ", new DateTime(2016, 08, 15), 6_000_000, "Tegal", 500_000);
            Programmer prog11 = new Programmer(122, "Charlie", "Van Dijk    ", new DateTime(2017, 09, 05), 6_000_000, "Tegal", 400_000);
            WriteLine("===================================================List Programmer===============================================================");

            //store to list (mempermudah menampilkan menggunakan list)
            List<Employee> listEmployees = new List<Employee> { prog9,prog10,prog11 };

            foreach (var item in listEmployees)
            {
                WriteLine(item.ToString());
            }

            WriteLine();
            WriteLine("================================================================================================================================");
            WriteLine($"Total employee : {Employee.totalEmployee}");
            WriteLine($"total Basic Salary : {Employee.totalBasic.ToString("C", new CultureInfo("Id-ID"))}");
            WriteLine("================================================================================================================================");
            Console.WriteLine("Press any key to .............");
            Console.ReadLine();
        }
        public static void No2()
        {
            Sales sales12 = new Sales(123, "Dian", "Permana    ", new DateTime(2017, 10, 12), 3_000_000, "Medan", 500_000, 200_000);
            Sales sales13 = new Sales(125, "Fatur", "Rohman    ", new DateTime(2019, 01, 15), 3_000_000, "Medan", 350_000, 250_000);
            //store to list (mempermudah menampilkan menggunakan list)
            List<Employee> listEmployees = new List<Employee> { sales12,sales13 };
            WriteLine("=======================================================List Sales===============================================================");
            foreach (var item in listEmployees)
            {
                WriteLine(item.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to .............");
        }
        public static void No3()
        {

            QA qa14 = new QA(124, "Elise", "Toon    ", new DateTime(2019, 01, 15), 4_500_000, "Tegal", 10_000);
            QA qa15 = new QA(126, "Gita", "Gutawa    ", new DateTime(2019, 03, 01), 4_500_000, "Tegal", 10_000);
            //store to list (mempermudah menampilkan menggunakan list)
            List<Employee> listEmployees = new List<Employee> {qa14,qa15};
            WriteLine("===================================================List Quality A==============================================================");
            foreach (var item in listEmployees)
            {
                WriteLine(item.ToString());
            }

            WriteLine();
            WriteLine("================================================================================================================================");
            WriteLine($"Total employee : {Employee.totalEmployee}");
            WriteLine($"total Basic Salary : {Employee.totalBasic.ToString("C", new CultureInfo("Id-ID"))}");
            WriteLine("================================================================================================================================");
            Console.WriteLine("Press any key to .............");
            ReadLine();

        }

        public static void No4()
        {
            QA qa14 = new QA(124, "Elise", "Toon    ", new DateTime(2019, 01, 15), 4_500_000, "Tegal", 10_000);
            QA qa15 = new QA(126, "Gita", "Gutawa    ", new DateTime(2019, 03, 01), 4_500_000, "Tegal", 10_000);
            Sales sales12 = new Sales(123, "Dian", "Permana    ", new DateTime(2017, 10, 12), 3_000_000, "Medan", 500_000, 200_000);
            Sales sales13 = new Sales(125, "Fatur", "Rohman    ", new DateTime(2019, 01, 15), 3_000_000, "Medan", 350_000, 250_000);
            Programmer prog9 = new Programmer(120, "Anton", "Pratama    ", new DateTime(2015, 03, 13), 6_000_000, "Tegal", 500_000);
            Programmer prog10 = new Programmer(121, "Budi", "Junaedi    ", new DateTime(2016, 08, 15), 6_000_000, "Tegal", 500_000);
            Programmer prog11 = new Programmer(122, "Charlie", "Van Dijk    ", new DateTime(2017, 09, 05), 6_000_000, "Tegal", 400_000);
            //store to list (mempermudah menampilkan menggunakan list)
            List<Employee> listEmployees = new List<Employee> { prog9, prog10, prog11,sales12,sales13,qa14,qa15 };

            WriteLine("===================================================SEMUA LIST EMPLOYE=========================================================");
            foreach (var item in listEmployees)
            {
                WriteLine(item.ToString());
            }

            WriteLine();
            WriteLine("================================================================================================================================");
            WriteLine($"Total employee : {Employee.totalEmployee}");
            WriteLine($"total Basic Salary : {Employee.totalBasic.ToString("C", new CultureInfo("Id-ID"))}");
            WriteLine("================================================================================================================================");
            Console.WriteLine("Press any key to .............");
            ReadLine();

        }
        public string City1 { get => City; set => City = value; }
        public string Role { get => role; set => role = value; }
        public decimal TotalSalary { get => totalSalary; set => totalSalary = value; }

        //overloading constructor = menambah object


    }
}
