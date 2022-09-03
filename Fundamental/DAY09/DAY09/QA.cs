using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAY09
{
    internal class QA : Employee
    {
        private decimal makan;

        public QA(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary, string city,
                         decimal makan) : base(empId, firstName, lastName, joinDate, basicSalary, city)
        {
            this.Makan = makan;
            Role = "QA";
            TotalSalary = basicSalary + makan;
        }

        public decimal Makan { get => makan; set => makan = value; }


        public override string? ToString()
        {
            return $"{base.ToString()}| T.QA = {this.makan.ToString("C", new CultureInfo("Id-ID"))}| Total Salary : {TotalSalary.ToString("C", new CultureInfo("Id-ID"))}\n";
        } 
    }
}
