using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY10
{
    internal class Owner : Person
    {
        private int hasCompany;


        public Owner(string firstName, string lastName, string email, DateTime birthDay, int hasCompany) : base(firstName, lastName, email, birthDay)
        {
            SosialNumber = new Random().Next(1000, 1100); //S besar parameter (Gambar kunci Inggris) s kecil Method
            FirstName = firstName;  //
            LastName = lastName;
            Email = email;
            BirthDay = birthDay;
            this.hasCompany = hasCompany;
        }

        public int HasCompany { get => hasCompany; set => hasCompany = value; }

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
            return $"{base.ToString()} | HasCompany : {this.hasCompany}";
        }
    }
}
