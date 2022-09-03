using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAY08
{
    internal class Sales : Employee
    {
        private decimal comission;
        private decimal bonus;
        /*private decimal transportasi;*/

        public Sales(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary, string city,
                         decimal comission, decimal bonus) : base(empId, firstName, lastName, joinDate, basicSalary, city)
        {
            this.Commision = comission;
            this.Bonus = bonus;
            Role = "Sales";
            TotalSalary = basicSalary + comission +bonus;
        }

        public decimal Commision { get => comission; set => comission = value; }
        public decimal Bonus { get => bonus; set => bonus = value; }


        public override string? ToString()
        {
            return $"{base.ToString()}| T.Commision = {this.comission.ToString("C", new CultureInfo("Id-ID"))}" +
                $"| T.Bonus = {this.bonus.ToString("C", new CultureInfo("Id-ID"))}" +
                $"| Total Salary : {TotalSalary.ToString("C", new CultureInfo("Id-ID"))}\n";
        }
    }
}
