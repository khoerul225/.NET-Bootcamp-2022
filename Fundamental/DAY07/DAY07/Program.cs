using DAY07;

//MyCollections.InitList();
//MyCollections.InitStack();
//MyCollections.InitDictionary();
/*MyCollections.InitHastSet();
*///MyCollections.InitQueue();

//declare List<T>
var list = new List<string>() { "Asep", "Budi", "Charlie" };
var student = MyCollections.GetStudent(ref list);

foreach (var item in student)
{
    Console.Write($"{item} ");
}

Console.WriteLine();
Console.WriteLine();
/*
var numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
var myNumbers = MyCollections.GetStudent(ref numbers);
foreach (var item in myNumbers)
{
    Console.Write($"{item} ");
}*/

//No 1
/*QuizLogic03no1();*/


MyCollections.No1();
MyCollections.no2();
Console.ReadLine();