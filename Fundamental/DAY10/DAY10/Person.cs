using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace DAY10
{
    /// <summary>
    ///  1. Membuat class program
    ///  2. Membuat class Person, ditambahkan abstrack di depan class
    //      * internal abstract class Person (Sesudah)
    ///     * internal class Person    (Sebelum)
    ///  3. Membuat Instant Variabel
    ///  4. Membuat class Customer
    ///  5. Membuat construktor di Customer
    ///  6, Membuat ovveride di customer
    ///  7. Membuat Get and Set
    /// 
    /// </summary>

    internal abstract class Person // menambahkan file abstrack
    {
        private int sosialNumber;
        private string firstName;
        private string lastName;
        private string email;
        private DateTime birthDay;
        private decimal totalRevenue;



        protected Person(string firstName, string lastName, string email, DateTime birthDay)
        {
            ///Membuat instan Abstrack
            ///membuat Construktor 
            /// * Blok instan abstrak ctrl + dot generate construktoe

            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.birthDay = birthDay;

        }

        public int SosialNumber { get => sosialNumber; set => sosialNumber = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public decimal TotalRevenue { get => totalRevenue; set => totalRevenue = value; }
        
        ///Membuat ovveride ( Ctrl + . (Dot)) diisi sesuai instan variabel
        public override string? ToString()
        {
            return $"SocialNumber : {this.sosialNumber} | FullName : {this.firstName} | lastName : {this.lastName} | Email : {this.email} | BirthDay{this.birthDay} | Revenue {this.totalRevenue.ToString("C", new CultureInfo("id-ID"))}";
        }

        ///Membuat Methode
        public abstract decimal TotalIncome (Dictionary<string,decimal> data);
     
    }
}
