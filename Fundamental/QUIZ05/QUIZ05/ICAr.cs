using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ05
{
    internal interface ICar
    {


        public List<CAR> InitDataCAR();

        public void showList<T>(ref List<T> list);

        public CAR findCarByID(List<CAR> list, string id);

        public Dictionary<string, decimal> GetTotalRevenue(List<CAR> list);

        public List<CAR> FindRevenue(List<CAR> list, decimal starFrom, decimal endTo);

        public void ShowTotalRevnue(Dictionary<string, decimal> dict);

        public Dictionary<string, int> TotalcarByType(List<CAR> list);

        public void ShowTotalRevnueTy(Dictionary<string, int> dict);



    }
}
