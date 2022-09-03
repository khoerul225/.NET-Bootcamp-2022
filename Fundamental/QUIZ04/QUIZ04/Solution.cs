using System.Linq;
using System.Collections.Generic;
namespace QUIZ04
{
    class Solution
    {
        ///Function
        public static void ReadInt(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");

            }
            Console.WriteLine();
        }
        ///Perbaikan
        ///
        public static void a()
        {
            int[] arr = new int[10];

        }
        public static void Soal1p()
        {
            Console.Write("Masukan :");
            int n = Convert.ToInt32(Console.ReadLine());
            int [] mat = new int[n];
            int [] s = mat.Distinct().ToArray();            
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine("Output");      
            Console.WriteLine(n);
        }


    ///Method
    public static void DisplayList(List<string> list)
        {
            foreach (var i in list)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        public static void DisplayListt(List<int> list)
        {
            foreach (var i in list)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        public static void DisplayListC(List<char> list)
        {
            foreach (var i in list)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        public static void DisplayDic(Dictionary<string, int> dic)
        {
            foreach (var i in dic)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        public static List<string> InputList()
        {
            var list = new List<string>();
            bool done = false;
            while (!done)
            {
                string x = Console.ReadLine();
                if (x != "x" && x != "")
                {
                    list.Add(x);
                }
                else if (x == "")
                {
                    continue;
                }
                else
                {
                    done = true;
                }
            }
            return list;
        }
        //No 1
        public static void displayHashset(HashSet<int> number1)
        {

            foreach (int tampil in number1)
            {
                Console.Write($" {tampil}");
            }
        }


        public static void SameElement(HashSet<int> number1, HashSet<int> number2)
        {
            HashSet<int> result = new HashSet<int>(number1);
            result.IntersectWith(number2);
            Console.WriteLine("Elemen yang sama adalah : ");
            displayHashset(result);
        }

        public static void UnionElement(HashSet<int> number1, HashSet<int> number2)
        {
            HashSet<int> result = new HashSet<int>(number1);
            result.UnionWith(number2);
            Console.WriteLine("Tampilan union : ");
            displayHashset(result);
        }

        public static void ExceptElement(HashSet<int> number1, HashSet<int> number2)
        {
            HashSet<int> result = new HashSet<int>(number1);
            result.ExceptWith(number2);
            Console.WriteLine("Tampilan yang tidak sama : ");
            displayHashset(result);
        }

        public static void SymmetricExceptElement(HashSet<int> number1, HashSet<int> number2)
        {
            HashSet<int> result = new HashSet<int>(number1);
            result.SymmetricExceptWith(number2);
            Console.WriteLine("Tampilan element yang tidak sama A & B : ");
            displayHashset(result);
        }

        public static void Soal1()
        {
            HashSet<int> hs1 = new HashSet<int>() { 1, 2, 5, 6, 9 };
            HashSet<int> hs2 = new HashSet<int>() { 1, 2, 3, 4 };

            displayHashset(hs1);
            Console.WriteLine();
            displayHashset(hs2);
            Console.WriteLine();
            SameElement(hs1, hs2);
            Console.WriteLine();
            UnionElement(hs1, hs2);
            Console.WriteLine();
            ExceptElement(hs1, hs2);
            Console.WriteLine();
            SymmetricExceptElement(hs1, hs2);
            Console.WriteLine();
            Console.WriteLine();
        }



        public static void DisplayList(List<int> numbers)
        {

            foreach (int tampil in numbers)
            {
                Console.Write($" {tampil}");
            }
        }
        public static void Reverse(List<int> numbers)
        {
            numbers.Reverse();
            foreach (int tampil in numbers)
            {
                Console.Write($" {tampil}");
            }
        }

        public static void ReverseC(List<String> StringA)
        {
            StringA.Reverse();
            foreach (string tampil in StringA)
            {
                Console.Write($" {tampil}");
            }
        }

        public static void DisplayListC(List<String> StringA)
        {

            foreach (String tampil in StringA)
            {
                Console.Write($" {tampil}");
            }
        }


        public static void Soal2()
        {
            var numbers = new List<int>() { 1, 2, 3,4 };
            Console.WriteLine("Sebelum Reverse"); 
            DisplayList(numbers);
            Console.WriteLine();
            Console.WriteLine("Setelah Reverse");
            Reverse(numbers);
            Console.WriteLine();
            var StringA = new List<String>() {"A","AA","CCC","DDD"};
            Console.WriteLine("Sebelum Reverse");
            DisplayListC(StringA);
            Console.WriteLine();
            Console.WriteLine("Setelah Reverse");
            ReverseC(StringA);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }



        public static void hitungBuah(string buah)
        {
            int apel = 0;
            int semangka = 0;
            string[] x = buah.Split(',');
            for (int i = 0; i < x.Length; i++)
            {
                string[] n = x[i].Split(':');
                if (n[0] == "apel")
                {
                    apel += int.Parse(n[1]);
                }
                if (n[0] == "semangka")
                {
                    semangka += int.Parse(n[1]);
                }
            }
            Console.WriteLine($"apel={apel}\tsemangka={semangka}");
        }
        public static List<string> Intersect(List<string> A, List<string> B)
        {
            var intersect = A.Intersect(B).ToList();
            return intersect;
        }
        public static List<string> Union(List<string> A, List<string> B)
        {
            var union = A.Union(B).ToList();
            union.Sort();
            return union;
        }
        public static List<string> Except(List<string> A, List<string> B)
        {
            var except = A.Except(B).ToList();
            return except;
        }
        public static List<string> Distinct(List<string> A, List<string> B)
        {
            var distinct = Union(A, B).Except(Intersect(A, B)).ToList();
            return distinct;
        }

        public static List<string> Reverse(List<string> A)
        {
            A.Reverse();
            return A;
        }

        public  static void InitHasSet()
        {
            var hs1 = new HashSet<int>() { 1, 2, 5, 6, 9 };
            var hs2 = new HashSet<int>() { 1, 2, 3, 4 };
            var r1 = new HashSet<int>(hs1);
            IEnumerable<int> both1 = r1.Intersect(hs2);
            Console.WriteLine("-----r1---");
            foreach (var item in both1)
                Console.WriteLine(item);

        }


        public static void Soal3()
        {

            Console.Write("Input  : ");
            int[] items = { 1,1,2, 3, 4, 1, 2, 3};
            ReadInt(items);
            IEnumerable<int> uniqueItems = items.Distinct<int>();
            Console.WriteLine("Output : " + string.Join(",", uniqueItems));
            
            Console.Write("Input  : ");
            int[] items2 = { 7,5,3,5,1 };
            ReadInt(items2);
            IEnumerable<int> uniqueItems2 = items2.Distinct<int>();
            Console.WriteLine("Output : " + string.Join(",", uniqueItems2));
            
            Console.Write("Input  : ");
            int[] items3 = { 1,1,1,1,1,1 };
            ReadInt(items);

            IEnumerable<int> uniqueItems3 = items3.Distinct<int>();
            Console.WriteLine("Output : " + string.Join(",", uniqueItems3));
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        public static int GetRightPosition(List<int> output, int value)
        {
            int l = 0;
            int r = output.Count - 1;

            while (l <= r)
            {
                int mid = (l + r) / 2;

                if (output[mid] < value)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }

            return l;
        }

        public static bool IsElementExist(List<int> output, int value)
        {
            int l = 0;
            int r = output.Count - 1;

            while (l <= r)
            {
                int mid = (l + r) / 2;

                if (output[mid] == value)
                {
                    return true;
                }

                if (output[mid] < value)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }

            return false;
        }

        public static List<int> LongestIncreasingSubSequence(int[] input)
        {
            List<int> output = new List<int>();
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (output.Count == 0)
                {
                    output.Add(input[i]);
                    dictionary[input[i]] = Int32.MinValue;
                }
                else
                {
                    if (!IsElementExist(output, input[i]))
                    {
                        if (input[i] > output.Last())
                        {
                            output.Add(input[i]);
                            dictionary[input[i]] = output[output.Count - 2];
                        }
                        else
                        {
                            int position = GetRightPosition(output, input[i]);

                            output[position] = input[i];

                            if (position == 0)
                            {
                                dictionary[input[i]] = Int32.MinValue;
                            }
                            else
                            {
                                dictionary[input[i]] = output[position - 1];
                            }

                        }
                    }
                }
            }

            int lastElement = output.Last();
            List<int> finalResult = new List<int>();

            while (lastElement != Int32.MinValue)
            {
                finalResult.Add(lastElement);
                lastElement = dictionary[lastElement];
            }

            return finalResult;
        }


        public static void Soal4()
        {
            int[] input = { 7, 2, 7, 1, 2, 5, 7, 1 };
            List<int> finaList = LongestIncreasingSubSequence(input);
            Console.WriteLine("Input:");
            ReadInt(input);
            Console.WriteLine("Output:");
            for (int i = finaList.Count - 1; i >= 0; i--)
            {
                Console.Write(finaList[i]);
            }
            Console.WriteLine();
            Console.WriteLine();

            int[] input2 = { 7, 2, 7, 1, 2, 3, 8, 1, 2, 3, 4, 5 };
            List<int> finaList2 = LongestIncreasingSubSequence(input2);
            Console.WriteLine("Input:");
            ReadInt(input2);
            Console.WriteLine("Output:");
            for (int i = finaList2.Count - 1; i >= 0; i--)
            {
                Console.Write(finaList2[i]);
            }
            Console.WriteLine();
            Console.WriteLine();

            int[] input3 = { 1, 1, 2, 2, 2, 3, 3, 3, 3 };
            List<int> finaList3 = LongestIncreasingSubSequence(input3);
            Console.WriteLine("Input:");
            ReadInt(input3);
            Console.WriteLine("Output:");
            for (int i = finaList3.Count - 1; i >= 0; i--)
            {
                Console.Write(finaList3[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }


        public static void Soal5()
        {
            Console.WriteLine("---------------------------");
            var A = new List<string> { "Mangga", "Apel", "Melon", "Pisang", "Sirsak", "Tomat", "Nanas", "Nangka", "Timun", "Mangga" };
            var B = new List<string> { "Bayam", "Wortel", "Kangkung", "Mangga", "Tomat", "Kembang Kol", "Nangka", "Timun" };
            Console.Write("Same\t\t: ");
            DisplayList(Intersect(A, B));
            Console.Write("Different\t: ");
            DisplayList(Distinct(A, B));
        }
        public static void Soal6()
        {
            // Creating a count variable

            // Creating an array of colors
            int[] Input = {1,2,3,4,4,4,3,4,2,4};
            Console.WriteLine("Input:");
            var total = 0;
            var total2 = 0;
            // Counting the total number of time blue appears
            // in the array
            ReadInt(Input);
            total = Input.Count(c => c == 4);

            // Displaying the count
            Console.WriteLine("Output:");
            Console.WriteLine(total);

            // Creating an array of colors
            int[] Input2 = { 1, 2, 3, 4, 4, 4, 3, 4, 2, 4 };
            Console.WriteLine("Input:");
            ReadInt(Input2);
            // Counting the total number of time blue appears
            // in the array
            total2 = Input2.Count(c => c == 4);

            // Displaying the count
            Console.WriteLine("Input:");
            Console.WriteLine(total2);
        }
        public static void Soal7()
        {
            Console.WriteLine("---------------------------");
            var A = new List<string>();
            var B = new List<string>();
            Console.Write("Input List A (input 'x' untuk selesai): ");
            A = InputList();
            Console.Write("A\t: ");
            DisplayList(A);
            Console.Write("Input List B (input 'x' untuk selesai): ");
            B = InputList();
            Console.Write("B\t: ");
            DisplayList(B);
            Console.Write("Output\t: ");
            DisplayList(ListAddition(A, B));
        }
        public static List<string> ListAddition(List<string> A, List<string> B)
        {
            string a = "";
            string b = "";
            var R = new List<string>();
            foreach (var i in A)
            {
                a += i;
            }
            foreach (var i in B)
            {
                b += i;
            }
            int numbA = Convert.ToInt32(a);
            int numbB = Convert.ToInt32(b);
            int numbR = numbA + numbB;
            string r = Convert.ToString(numbR);
            for (int i = 0; i < r.Length; i++)
            {
                R.Add(Convert.ToString(r[i]));
            }
            return R;
        }
        public static void Soal8()
        {
            Console.WriteLine("---------------------------");
            var B = new List<int>();
            List<int> A = new List<int>();
            A.Add(1);
            A.Add(2);
            A.Add(3);
            Console.WriteLine();
            Console.WriteLine("input");
            foreach (int x in A)
            { Console.Write($"{x} "); }
            Console.WriteLine();
            Console.WriteLine("output");
            A.Reverse();
            foreach (int y in A) { Console.Write($"{y} "); }
            Console.WriteLine();


        }
        public static List<string> ListAddReverse(List<string> A, List<string> B)
        {
            string a = "";
            string b = "";
            var R = new List<string>();
            foreach (var i in A)
            {
                a += i;
            }
            A.Reverse();
            foreach (var i in B)
            {
                b += i;
            }
            B.Reverse();
            int numbA = Convert.ToInt32(a);
            int numbB = Convert.ToInt32(b);
            int numbR = numbA + numbB;
            string r = Convert.ToString(numbR);
            for (int i = 0; i < r.Length; i++)
            {
                R.Add(Convert.ToString(r[i]));
            }
            R.Reverse();
            return R;
        }
        public static void Soal9()
        { 
            Console.WriteLine("---------------------------");
            Console.Write("Input1\t: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Count\t: ");
            int c = Convert.ToInt32(Console.ReadLine());
            DisplayList(CountSequence(x, c));
        }

        public static void MasukSoal9()
        {
            Console.Write("Pilih soal (1/2)\t: ");
            int no = Convert.ToInt32(Console.ReadLine());
            switch (no)
            {
                case 2:
                    QUIZ04.Solution.Main();
                    break;
                case 1:
                    QUIZ04.Solution.Soal9();
                    break;
            }
        }

        public static void Main() ///B
        {
            Console.Write("Input1()\t: ");
            int no = Convert.ToInt32(Console.ReadLine());
            switch (no)
            {
                case 1:
                    Console.Write("Monday\t: ");
                    QUIZ04.Solution.Soal9a();
                    break;
                case 2:
                    Console.Write("Tuesdey\t: ");
                    QUIZ04.Solution.Soal9a();
                    break;
                case 3:
                    Console.Write("Wednesday\t: ");
                    break;
                case 4:
                    Console.Write("Thursday\t: ");
                    QUIZ04.Solution.Soal9a();
                    break;
                case 5:
                    Console.Write("Friday\t: ");
                    QUIZ04.Solution.Soal9a();
                    break;
                case 6:
                    Console.Write("Saturday\t: ");
                    QUIZ04.Solution.Soal9a();
                    break;
                case 7:
                    Console.Write("Sunday\t: ");
                    QUIZ04.Solution.Soal9a();
                    break;

            }


        }




        public static void Soal9a()

        {
            Console.WriteLine();
            Console.Write("Count\t: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            string[] cars = { "FRIDAY","SATURDAY","SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY" };
            for (int i = 0; i < n; i++)
            {
                Console.Write(cars[i] + " ");
            }
            Console.WriteLine();
        }


        public static List<string> CountSequence(int currentValue, int sequenceLength)
        {
            var A = new List<string>();
            for (int i = currentValue; i < currentValue + sequenceLength; i++)
            {
                A.Add(Convert.ToString(i));
            }
            return A;
        }


    }
}