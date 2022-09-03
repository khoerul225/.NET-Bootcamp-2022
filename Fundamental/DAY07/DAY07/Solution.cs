using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY07
{
    internal class MyCollections
    {
        public static void InitList()
        {
            var alfabet = new List<string> { "A", "B", "C", "D", "E" };
            alfabet.Add("F");
            alfabet.AddRange(new[] { "G", "H", "I" });
            alfabet.Insert(0, "J");
            alfabet.InsertRange(3, new[] { "X", "Y" });

            foreach (var item in alfabet)
            {
                Console.Write($"{item} ");
            }
             Console.WriteLine();

            //remove element  for list
            alfabet.Remove("Y");
            alfabet.RemoveRange(4, 6);
            alfabet.RemoveAll(v => v == "X");

            //declare list int
            var number = new List<int> { 2, 5, 7, 11, 13, 17, 19 };
            number.Add(23);
            /*number.Remove(13);
            number.RemoveAll(v => v == 7);*/

            //find element
            var a = number.Find(e => e < 10);
            var b = number.FindLast(e => e < 11);
            var c = number.FindAll(e => e <= 10);
            Console.WriteLine();

            //find element
            var d = number.FindIndex(e => e <= 11);
            var e = number.FindLastIndex(e => e <= 11);
            var f = number.IndexOf(13);
            var g = number.BinarySearch(11);
            Console.WriteLine();
        }

        public static void InitStack()
        {
            var numbers = new Stack<int>(new int[] { 1, 2, 3 });
            numbers.Push(5);
            numbers.Push(7);

            //remove pop
            numbers.Pop();
            var n = numbers.Peek();
            numbers.Clear();

        }

        public static void InitDictionary()
        {
            var pl = new Dictionary<int, string>();
            pl.Add(1, "C#");
            pl.Add(2, "Java");

            var pl2 = new Dictionary<int, string>()
            {
                {1, "C#" },
                {2, "Java" },
                {3, "Python" }
            };

            //add element
            pl2.Add(4, "Golang");
            pl2.TryAdd(4, "SQl");

            //update element value
            pl2[4] = "SQL";

            foreach (var item in pl2)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.WriteLine();
        }

        //store Uniqe Element
        public static void InitHastSet()
        {
            var numbers = new HashSet<int>() { 1, 2, 3, 5, 8 };
            numbers.Add(5);
            numbers.Add(10);
            numbers.Add(8);

            var hs1 = new HashSet<int>() { 1, 2, 5, 6, 9 };
            var hs2 = new HashSet<int>() { 1, 2, 3, 4 };

            /*var r1 = new HashSet<int>(hs1);
            IEnumerable<int> hs2 = new HashSet<int>(hs2);
            r1.IntersectWith(hs2); //inner join,  result = 1, 2
*/
            var r1 = new HashSet<int>(hs1);
            IEnumerable<int> both1 = r1.Intersect(hs2);
            Console.WriteLine("-----r1---");
            foreach (var item in both1)
                Console.WriteLine(item);


            var r2 = new HashSet<int>(hs1);
            IEnumerable<int> both2 = r2.Union(hs2);
            Console.WriteLine("-----r2---");
            foreach (var item in both2)
                Console.WriteLine(item);
            // union => 1,2,3,4,5,6,9

            var r3 = new HashSet<int>(hs1);
            IEnumerable<int> both3 = r3.Except(hs2);
            Console.WriteLine("-----r3---");
            var both4 = r3.Except(hs1);
            foreach (var item in both3)
                Console.WriteLine(item);


            Console.WriteLine("---------");
            var r4 = new HashSet<int>(hs1);
            r4.SymmetricExceptWith(hs2); //output 3,4,5,6,9
            //Convert hashset to list
            Console.WriteLine("-----r4---");
            var myNumber = r4.ToList();
            foreach (var item in myNumber)
                Console.WriteLine(item);
        }

        //Jawaban N01


        public static void InitQueue()
        {
            var queue = new Queue<string>();
            queue.Enqueue("Asep");
            queue.Enqueue("Budi");
            queue.Enqueue("Charlie");

            Console.WriteLine($" Queue from front to back");
            foreach (var item in queue)
            {
                Console.Write($"{item} ");
            }

            string served = queue.Dequeue();
            Console.WriteLine($"Served : {served}");
        }

        //return List<T>
        public static List<T> GetStudent<T>(ref List<T> list)
        {
            var myList = new List<T>();
            foreach (var item in list)
            {
                myList.Add(item);
            }
            return myList;
        }

        public static void No1()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
            ////Dibaca
            var myNumbers = MyCollections.GetStudent(ref numbers);
            ///ditampilkan
            foreach (var item in myNumbers)
            {
                Console.Write($"{item} ");
            }
            //Setelah ini kembali ke Program

            Console.WriteLine();
        }



        public static void no2()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("--------------N01----------");
            Console.WriteLine("---------------------------");

            var hs1 = new HashSet<int>() { 1, 2, 5, 6, 9 };
            var hs2 = new HashSet<int>() { 1, 2, 3, 4 };

            var r1 = new HashSet<int>(hs1);
            IEnumerable<int> both1 = r1.Intersect(hs2);
            Console.WriteLine("A irisan B)");
            foreach (var item in both1)
                Console.Write($"{item} ");
            Console.WriteLine();
            Console.WriteLine("---------------------------");

            var r2 = new HashSet<int>(hs1);
            IEnumerable<int> both2 = r2.Union(hs2);
            Console.WriteLine("A union B");
            foreach (var item in both2)
                Console.Write($"{((short)item)}");


            Console.WriteLine();
            Console.WriteLine("---------------------------");
            // union => 1,2,3,4,5,6,9
            var r3 = new HashSet<int>(hs1);
            IEnumerable<int> both3 = r3.Except(hs2);
            Console.WriteLine("A yang tidak sama dengan B");
            var both4 = r3.Except(hs1);
            foreach (var item in both3)
                Console.Write($"{item} ");
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            var r4 = new HashSet<int>(hs1);
            r4.SymmetricExceptWith(hs2); //output 3,4,5,6,9
            //Convert hashset to list
            Console.WriteLine("Yang tidak sama di A & B");
            var myNumber = r4.ToList();
            foreach (var item in myNumber)
                Console.Write($"{item} ");
            Console.WriteLine();
            Console.WriteLine("---------------------------");
        }



    }
}
