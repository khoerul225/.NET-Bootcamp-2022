using static System.Console;
using System.Globalization;
//call class CAR
using QUIZ05;

//CAR cr = new CAR("D 1001 UM", new DateTime(2015), "SUV", 0M);

//WriteLine(cr.ToString());
//CAR cr1 = new CAR("D 1001 UK",new DateTime(2016),300_000;

Console.WriteLine("=============================================List Kendaraan==================================================================================");
ICar carInterface = new CARlmpl();
var ListOfKendaraan = carInterface.InitDataCAR();
carInterface.showList(ref ListOfKendaraan);

Console.WriteLine("=========================================FIND CAR BY NOPOLISI================================================================================");
var carr = carInterface.findCarByID(ListOfKendaraan, "D 1001 UM");
WriteLine($" KENDARAAN {carr}");

var carr2 = carInterface.findCarByID(ListOfKendaraan, "D 55 UJ");
WriteLine($" KENDARAAN {carr2}");

var carr3 = carInterface.findCarByID(ListOfKendaraan, "D 87 UK");
WriteLine($" KENDARAAN {carr3}");

Console.WriteLine("==========================================Get Total Revenue==================================================================================");
var Total = carInterface.GetTotalRevenue(ListOfKendaraan);
carInterface.ShowTotalRevnue(Total);

Console.WriteLine("=======================================Total Kendaraan By type===============================================================================");
var ByType = carInterface.TotalcarByType(ListOfKendaraan);
carInterface.ShowTotalRevnueTy(ByType);
Console.WriteLine("=============================================================================================================================================");




