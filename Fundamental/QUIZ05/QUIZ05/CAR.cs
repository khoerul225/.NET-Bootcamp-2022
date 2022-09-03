using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ05
{
    internal class CAR
    {
        //Instan Variabel
        private string noPolisi;
        private int tahun;
        private decimal totalRevenue = 0M;
        private string type;



        public CAR()
        {

        }

        public CAR(string noPolisi, int tahun)
        {
            this.noPolisi = noPolisi;
            this.tahun = tahun;
            this.totalRevenue = totalRevenue;
        }

        public CAR(string noPolisi, int tahun, decimal totalRevenue, string type)
        {
            this.noPolisi = noPolisi;
            this.tahun = tahun;
            this.totalRevenue = totalRevenue;
            this.type = type;
        }

        public string NoPolisi { get => noPolisi; set => noPolisi = value; }
        public int Tahun { get => tahun; set => tahun = value; }
        public decimal TotalRevenue { get => totalRevenue; set => totalRevenue = value; }
        public string Type { get => type; set => type = value; }




        //Construktor Parameter


        public override string? ToString()
        {
            return $" Angkot \t = {this.noPolisi} | {this.tahun} |{this.type} |{this.totalRevenue.ToString("C", new CultureInfo("id-ID"))}";
        }

    }


}
