using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY10
{
    internal class Customer : Person
    {
        ///2 kali generate construktor di Customer
        /// untuk membuat 2 Methode 
        private string accountNumber;
        public Customer( string firstName, string lastName, string email, DateTime birthDay, string accountNumber = null) : base( firstName, lastName, email, birthDay)
        {
            SosialNumber = new Random().Next(1000,1100); //S besar parameter (Gambar kunci Inggris) s kecil Method
            FirstName = firstName;  //
            LastName = lastName;
            Email = email;
            BirthDay = birthDay;
            this.accountNumber = accountNumber;
        }

        public string AccountNumber { get => accountNumber; set => accountNumber = value; }

        public override decimal TotalIncome(Dictionary<string, decimal> data)
        {
            var totalIncome = 0M; ///agar dibaca Decimal
            foreach (var item in data)
            {
                totalIncome += item.Value;
            }

            return totalIncome;

        }

        public override string? ToString()
        {
            return $"{base.ToString()} | AccountNumber : {this.accountNumber}";
        }
    }
}
