using static System.Console;

namespace DAY04
{
    internal class Arrays
    {
        public static void IntroArrays()
        {
            // declare array with int data type
            int[] arr;
            int[] arrInt = new int[5];
            arrInt[0] = 1;
            arrInt[1] = 2;
            arrInt[2] = 3;
            arrInt[4] = 98_000_000;
            //arrInt[3] = 4; // out of range

            // declare array with double
            double[] arrDouble = new double[2];
            arrDouble[0] = 34.5;
            arrDouble[1] = 100.98;

            //declare array money
            decimal[] arrDecimal = new decimal[2];
            arrDecimal[0] = 4.98M;
            arrDecimal[1] = 98.987M;

            //init array with value
            double[] points = new double[] { 10.98, 98.09,76.12,54.55 };
            string[] listOfGirl = new string[] { "Rini", "Yuli", "Widi" };
            listOfGirl[0] = "Rini Wulandari";
            char[] chars = new char[listOfGirl.Length];

            //display array
            foreach (var item in listOfGirl)
            {
                WriteLine($"{item}");
            }

            for (int i = 0; i < listOfGirl.Length; i++)
            {
                listOfGirl[1] = "Yuli Windi";
                WriteLine($"{listOfGirl[i]}");
            }
        }

        // function return array
        public static int[] InitArraysInt(int[] arr)
        {
            int[] array = arr;
            return array;
        }

        public static void DisplayArrayInt(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
        }

        public static string[] InitArraysString(string[] arr)
        {
            string[] array = arr;
            return array;
        }

        public static void DisplayArrayString(string[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
        }

        public static int[] InitRandomArray(int n)
        {
            int[] arr= new int[n];
            Random random = new Random();
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(51);
            }

            return arr;
        }


        public static double SumAllElement(int[] arr)
        {
            double sum = 0.0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public static int FindLargestElement(int[] arr)
        {
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        //4 finding smales element
        public static int FindIndexLargest(int[] arr)
        {
            int max = arr[0];
            int indexOfMax = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    indexOfMax = i;
                }
            }
            return indexOfMax;
        }

        // 5 copying array
        public static void CopyingArray()
        {
            int[] sourceArray = { 2, 3, 5, 7, 11, 1 };
            int[] targetArray = new int[sourceArray.Length];

            for (int i = 0; i < sourceArray.Length; i++)
            {
                targetArray[i] = sourceArray[i];
            }

            // gunakan method
            Array.Copy(sourceArray, 0, targetArray, 0, sourceArray.Length);


        }

    }
}
