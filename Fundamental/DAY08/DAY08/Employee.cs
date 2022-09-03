using System;
using static System.Console;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY08
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

        /// <summary>
        /// Hente perlu
        /// </summary>
        /// <returns></returns>


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

        public string City1 { get => City; set => City = value; }
        public string Role { get => role; set => role = value; }
        public decimal TotalSalary { get => totalSalary; set => totalSalary = value; }

        //overloading constructor = menambah object


    }
}
