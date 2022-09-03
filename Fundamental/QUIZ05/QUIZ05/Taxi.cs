using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ05
{
    internal class Taxi : CAR
    {
        private int order;
        private decimal orderPerKM;
        private int totalKM;
        private decimal bonus;

        public Taxi(string noPolisi, int tahun, int order, decimal orderPerKM, int totalKM, decimal bonus) : base(noPolisi, tahun)
        {
            this.order = order;
            this.orderPerKM = orderPerKM;
            this.totalKM = totalKM;
            this.bonus = bonus;
            this.Type = "Taxi";
            TotalRevenue = (order * bonus) + (orderPerKM * totalKM);
        }

        public int Order { get => order; set => order = value; }
        public decimal OrderPerKM { get => orderPerKM; set => orderPerKM = value; }
        public int TotalKM { get => totalKM; set => totalKM = value; }
        public decimal Bonus { get => bonus; set => bonus = value; }

        public override string ToString()
        {
            return $"{base.ToString()} | Order = {this.order.ToString("C", new CultureInfo("id-ID"))}  |" +
                $" OrderPerKm= {this.OrderPerKM.ToString("C", new CultureInfo("id-ID"))} " +
                $"| TotalKm= {this.totalKM.ToString("C", new CultureInfo("id-ID"))}" +
                $"| Bonus= {this.bonus.ToString("C", new CultureInfo("id-ID"))}";
        }
    }
}
