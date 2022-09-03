using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAY08
{
    internal class Programmer : Employee
    {
        private decimal transportasi;

        public Programmer(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary, string city,
                         decimal transportasi) : base(empId, firstName, lastName, joinDate, basicSalary, city)
        {
            this.Transportasi = transportasi;
            Role = "Programmer";
            TotalSalary = basicSalary + transportasi;
        }

        public decimal Transportasi { get => transportasi; set => transportasi = value; }


        public override string? ToString()
        {
            return $"{base.ToString()}| T.Transportasi = {this.transportasi.ToString("C", new CultureInfo("Id-ID"))}| Total Salary : {TotalSalary.ToString("C", new CultureInfo("Id-ID"))}\n";
            Console.WriteLine();
        } 
    }
}
