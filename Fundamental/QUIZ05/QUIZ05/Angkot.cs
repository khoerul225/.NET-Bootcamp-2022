using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ05
{
    internal class Anggkot : CAR
    {
        private decimal hargatiket;
        private int totalpenumpang;

        public Anggkot(string noPolisi, int tahun, decimal hargatiket, int totalpenumpang) : base(noPolisi, tahun)
        {
            this.hargatiket = hargatiket;
            this.totalpenumpang = totalpenumpang;
            TotalRevenue = hargatiket * totalpenumpang;
            this.Type = "Angkot";
        }

        public decimal Hargatiket { get => hargatiket; set => hargatiket = value; }
        public int Totalpenumpang { get => totalpenumpang; set => totalpenumpang = value; }

        public override string ToString()
        {
            return $"{base.ToString()} | HT ={this.hargatiket.ToString("C", new CultureInfo("id-ID"))} " +
                $"|tp ={ this.totalpenumpang.ToString("C", new CultureInfo("id-ID"))}";
        }
    }
}
