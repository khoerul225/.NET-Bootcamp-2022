using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ05
{
    internal class SUV : CAR
    {
        private decimal sewa;
        private decimal supir;

        public SUV(string noPolisi, int tahun, decimal sewa, decimal supir) : base(noPolisi, tahun)
        {
            this.sewa = sewa;
            this.supir = supir;
            this.Type = "SUV";
            TotalRevenue = sewa + supir;
        }

        public decimal Sewa { get => sewa; set => sewa = value; }
        public decimal Supir { get => supir; set => supir = value; }

        public override string ToString()
        {
            return $"{base.ToString()} | Sewa = {this.sewa.ToString("C", new CultureInfo("id-ID"))}  | supir = {this.supir.ToString("C", new CultureInfo("id-ID"))}";
        }

    }
}
