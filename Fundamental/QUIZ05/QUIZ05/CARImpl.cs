using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ05
{
    internal class CARlmpl : ICar
    {
        //inisialisasi object yang dari kelas SUV,Angkot, taxi
        public List<CAR> InitDataCAR()
        {
            SUV SV1 = new SUV("D 1001 UM", 2015, 500_000, 100_000);
            SUV SV2 = new SUV("D 1002 UM", 2019, 500_000, 100_000);

            Taxi tx1 = new Taxi("D 88 UK", 2018, 5, 45_000, 40, 10_000);
            Taxi tx2 = new Taxi("D 87 UK", 2018, 10, 45_000, 100, 10_000);

            Anggkot angk1 = new Anggkot("D 55 UJ", 2016, 4_500, 35);
            Anggkot angk2 = new Anggkot("D 56 UJ", 2015, 4_500, 40);

            return new List<CAR> { SV1, SV1, tx1, tx2, angk1, angk2 };
        }

        public void showList<T>(ref List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
        }
        public CAR findCarByID(List<CAR> list, string id)
        {
            CAR cr = null;
            foreach (var item in list)
            {
                if (item.NoPolisi == id)
                {
                    cr = item;
                }
            }
            return cr;
        }

        public Dictionary<string, decimal> GetTotalRevenue(List<CAR> list)
        {
            var totalRev = new Dictionary<string, decimal>();
            decimal revSUV = 0;
            decimal revANG = 0;
            decimal revTAX = 0;
            foreach (var item in list)
            {
                if (item.Type == "Taxi")
                {
                    revTAX += item.TotalRevenue;
                }
                else if (item.Type == "Angkot")
                {
                    revANG += item.TotalRevenue;
                }
                else if (item.Type == "SUV")
                {
                    revSUV += item.TotalRevenue;
                }
            }
            totalRev.Add("Taxi", revTAX);
            totalRev.Add("Angkot", revANG);
            totalRev.Add("SUV", revSUV);

            return totalRev;
        }
        public void ShowTotalRevnue(Dictionary<string, decimal> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"Kendaraan {item.Key} \nJumlah Reveneu :\t{item.Value}");
                Console.WriteLine();
            }
        }

        public List<CAR> FindRevenue(List<CAR> list, decimal starFrom, decimal endTo)
        {
            var carRange = new List<CAR>();

            foreach (var item in list)
            {
                if (item.TotalRevenue >= starFrom && item.TotalRevenue <= endTo)
                {
                    carRange.Add(item);
                }
            }
            return carRange;
        }

        public Dictionary<string, int> TotalcarByType(List<CAR> list)
        {
            var dict = new Dictionary<string, int>();
            int toSUV = 0;
            int toTax = 0;
            int toAng = 0;

            foreach (var item in list)
            {
                if (item.Type == "Taxi")
                {
                    toSUV++;
                }
                else if (item.Type == "Angkot")
                {
                    toTax++;
                }
                else if (item.Type == "SUV")
                {
                    toAng++;
                }
            }
            dict.Add("Taxi", toTax);
            dict.Add("Angkot", toAng);
            dict.Add("SUV", toSUV);

            return dict;
        }
        public void ShowTotalRevnueTy(Dictionary<string, int> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"Kendaraan {item.Key}\nJumlah :{item.Value}");
            }
        }
    }
}
