using static System.Console;
using DAY10;


/// <summary>
/// Kodingan terbanyak di program dan custmer
/// 
/// </summary>

Person yuli = new Customer ("Yuli", "Ayu", "yuliAyu@gmail.com", new DateTime(1998,4,24), "110-110");
Person widi = new Customer ("Widi", "Amalia", "widiAmalia@gmail.com", new DateTime(1998,09,30),"110-111");
Person rini = new Customer ("Rini", "Marlina", "riniMarlina@gmail.com", new DateTime(1998,08,04),"110-112");

Person Anto = new Owner ("Anto", "Bootcamp", "AntoBootcamp@gmail.com", new DateTime(1998, 4, 23),1);
Person Fajar = new Owner("Fajar", "Bootcamp", "FajarBootcamp@gmail.com", new DateTime(1998, 4, 22), 5);
Person Riyan = new Owner("Riyan", "Bootcamp", "RiyanBootcamp@gmail.com", new DateTime(1998, 4, 21), 9);


//Suber data
var listOfCustomer = new List<Person> {yuli,widi,rini};

var incomeYuli = new Dictionary<string, decimal> 
{
{"Kontrakan",20_000_0000},
{"Toko",10_000_0000}
};  /*yuli.TotalIncome(incomeYuli);*/
yuli.TotalRevenue = yuli.TotalIncome(incomeYuli);

var incomeWidi = new Dictionary<string, decimal>
{
{"Kosan",10_000_0000},
{"Jual Online",10_000_0000}
};
widi.TotalRevenue = widi.TotalIncome(incomeWidi);

var incomeRini = new Dictionary<string, decimal>
{
{"Supermarket",10_000_0000},
{"Rental Ps",10_000_0000}
};

rini.TotalRevenue = rini.TotalIncome(incomeRini);

foreach (var item in listOfCustomer)
{
    WriteLine(item);
}

var listOfCompany = new List<Person> { Anto, Fajar, Riyan };

var companyAnto = new Dictionary<string, decimal>
{
{"Telkom",10_000_0000},
{"Tokopedia",10_450_0000},
{"Shopee",10_089_0000},
};
Anto.TotalRevenue = Anto.TotalIncome(companyAnto);

var companyFajar = new Dictionary<string, decimal>
{
{"Fajar Optik",10_000_0000},
{"Cyber Store",15_000_0000},
};
Fajar.TotalRevenue = Fajar.TotalIncome(companyFajar);

var companyRiyan = new Dictionary<string, decimal>
{
{"Tekwan Palembang",16_000_0000},
{"Tekwan Cyber",19_000_0000},
{"Tekwan Service",10_000_0000}
};
Riyan.TotalRevenue = Riyan.TotalIncome(companyRiyan);
foreach (var item in listOfCompany)
{
    WriteLine(item);
}




WriteLine("================================Revenue Highest==================================================");
var listRange = listOfCustomer.Where(x => x.TotalRevenue < 300_000_000).ToList();
foreach (var item in listRange)
{
    WriteLine(item.ToString());
}

WriteLine();

var listMin = listOfCustomer.Min(x => x.TotalRevenue);
WriteLine($"Cust Min Revenue : {listMin}");

var listMax = listOfCustomer.Max(x => x.TotalRevenue);
WriteLine($"Cust Max Revenue : {listMax}");



var listThenMax = listOfCustomer.Where(x => x.TotalRevenue<listMax);
WriteLine("================================Revenue LowerThen Highest==================================================");
foreach (var item in listThenMax)
{
    WriteLine(item.ToString());
}

//Construktor adalah epenghubung kesemua Class
WriteLine("================================Select==================================================");
var query = listOfCustomer.Select
(cust=>
    new
    {
        FullName = cust.FirstName + " " + cust.LastName,
        Email = cust.Email,
        TotalRevenue = cust.TotalRevenue
    }
);

/// Kurung Biasa

foreach (var item in query)
{
    WriteLine(item);
}


WriteLine("=====================================================================================");
WriteLine("=====================================================================================");
WriteLine("=====================================================================================");
WriteLine("================================Revenue Highest==================================================");

var listRange2 = listOfCompany.Where(x => x.TotalRevenue < 300_000_000).ToList();
foreach (var item in listRange2)
{
    WriteLine(item.ToString());
}

WriteLine();

var listMin2 = listOfCompany.Min(x => x.TotalRevenue);
WriteLine($"Owne Min Revenue : {listMin2}");

var listMax2 = listOfCompany.Max(x => x.TotalRevenue);
WriteLine($"Owne Max Revenue : {listMax2}");



var listThenMax2 = listOfCompany.Where(x => x.TotalRevenue < listMax);
WriteLine("================================Revenue LowerThen Highest==================================================");
foreach (var item in listThenMax2)
{
    WriteLine(item.ToString());
}

//Construktor adalah epenghubung kesemua Class
WriteLine("================================Select==================================================");
var query2 = listOfCompany.Select
(owne =>
    new
    {
        FullName = owne.FirstName + " " + owne.LastName,
        Email = owne.Email,
        TotalRevenue = owne.TotalRevenue
    }
);

/// Kurung Biasa

foreach (var item in query2)
{
    WriteLine(item);
}




LinQ.IntroLinQ();