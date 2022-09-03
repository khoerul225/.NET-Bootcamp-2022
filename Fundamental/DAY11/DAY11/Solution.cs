using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTestKm
{
    internal class Solution
    {
        public static int NumberOne(int number)
        {
            int distance = 10;
            int count = 0;
            for (int i = 30; i < number; i++)
            {
                distance = distance + i;
                count++;
                if (distance >= number)
                {
                    break;
                }
            }
            return count;
        }

        public static int NumberTwo(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
        public static int NumberThree(int number)
        {
            int result = 0;
            for (int i = 0; i <= number; i++)
            {
                result += i;
            }
            return result;
        }
        /*      public static int NumberFour(int number)
                {
                int n, t1 = 0, t2 = 1, nextTerm = 0;
                n = 0;
                for (int i = 1; i <= number; i++)
                {
                }
                return 0;
                }
        */

        /*public static int[] Fibonacci(int number)
        {
            int[] a = new int[number];
            a[0] = 0;
            a[1] = 1;
            for (int i = 2; i < number; i++)
            {
                a[i] = a[i - 2] + a[i - 1];
            }
            return a;
        }
*/

        public static int NumberFour(int n) ///Fibonanci
        {
            int firstnumber = 0, secondnumber = 1, result = 0;

            if (n == 0) return 0; //To return the first Fibonacci number   
            if (n == 1) return 1; //To return the second Fibonacci number   


            for (int i = 2; i <= n; i++)
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
            }

            return result;
        }



        public static int[] Fibonacci(int number)
        {
            int[] a = new int[number];
            a[0] = 0;
            a[1] = 1;
            for (int i = 2; i < number; i++)
            {
                a[i] = a[i - 2] + a[i - 1];
            }
            return a;
        }
        public static void NumberFive(int number)
        {
            var b = Fibonacci(number);
            foreach (var elements in b)
            {
                Console.WriteLine(elements);
            }
        }


        public static string NumberSix(string number)
        {
            string result = "FALSE";
            for (int i = 1; i <= number.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result = "TRUE";
                }
                else
                {
                    result = "FALSE";
                }
            }
            return result;
        }
        public static string NumberSeven(string number1, string number2)
        {
            string result = "FALSE";
            string savenumber1 = number1.ToLower();
            string savenumber2 = number2.ToLower();
            string a = "";
            if (number1.Length != number2.Length)
            {
                result = "FALSE";
            }
            else
            {
                for (int i = 0; i < savenumber1.Length; i++)
                {
                    for (int j = 0; j < savenumber2.Length; j++)
                    {
                        if (savenumber1[i] == savenumber2[j])
                        {
                            a += savenumber1[i];
                            break;
                        }
                    }
                }
            }
            if (a == savenumber1)
            {
                result = "True";
            }
            else
            {
                result = "False";
            }
            return result;
        }
        public static int[,] NumberEight(int b, int k)
        {
            int[,] matrix = new int[b, k];
            int counter = b;
            int count = 10;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i >= j)
                    {
                        matrix[i, 0] = count;
                    }
                }
            }
            return matrix;
        }
        public static void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++) // looping rows
            {
                for (int j = 0; j < matrix.GetLength(1); j++)//loop column
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static int[,] NumberNine(int b, int k)
        {
            int[,] matrix = new int[b, k];
            int counter = b;
            int count = 10;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i >= j)
                    {
                        matrix[i, 0] = count;
                    }
                }
            }
            return matrix;
        }

    }
}