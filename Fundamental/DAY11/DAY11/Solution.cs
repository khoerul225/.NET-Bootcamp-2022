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
            a[0] = 1;
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
                Console.Write(elements);
                
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
        //Use Function
        public static int[,] NumberEightMat1(int baris, int column)
        {
            int[,] matrik = new int[baris, column];
            int count = 10;
            int n = column - 1;
            int x;

            for (int i = 0; i < matrik.GetLength(0); i++)
            {
                count = 10;
                for (int j = 0; j < matrik.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        matrik[i, j] = count--;
                    }
                    else if (i == 1 && j < n)
                    {
                            matrik[i, j] = count--;
                    }
                    else if (i == 2 && j < n - 1)
                    {
                            matrik[i, j] = count--;
                    }
                    else if (i == 3 && j < n - 2)
                    {
                            matrik[i, j] = count--;
                    }
                    else if (i == 4 && j == 0)
                    {
                            matrik[i, j] = 10;
                    }
                }
            }
            return matrik;
        }
        //Use Methode
        public static void NumberEightMat1M(int baris, int column)
        {
            int[,] matrik = new int[baris, column];
            int count = 10;
            int n = column - 1;
            int x;

            for (int i = 0; i < matrik.GetLength(0); i++)
            {
                count = 10;
                for (int j = 0; j < matrik.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        matrik[i, j] = count--;
                        Console.Write($"{matrik[i, j]}\t");
                    }
                    else if (i == 1 && j < n)
                    {
                        matrik[i, j] = count--;
                        Console.Write($"{matrik[i, j]}\t");
                    }
                    else if (i == 2 && j < n - 1)
                    {
                        matrik[i, j] = count--;
                        Console.Write($"{matrik[i, j]}\t");
                    }
                    else if (i == 3 && j < n - 2)
                    {
                        matrik[i, j] = count--;
                        Console.Write($"{matrik[i, j]}\t");
                    }
                    else if (i == 4 && j == 0)
                    {
                        matrik[i, j] = 10;
                        Console.Write($"{matrik[i, j]}\t");
                    }
                    else
                    {
                        Console.Write($"\t");
                    }
                }
                Console.WriteLine();
            }
        }

        //Menggunakan Function
        public static int[,] NumberEightMat2(int baris, int column)
        {
            int[,] matrik = new int[baris, column];
            int count1 = 1;
            int count2 = 2;
            int count3 = 3;
            int count4 = 4;
            int count5 = 5;

            int n = column - 1;

            for (int i = 0; i < matrik.GetLength(0); i++)
            {
                for (int j = 0; j < matrik.GetLength(1); j++)
                {
                    if (i == 0 && j < 1)
                    {
                        matrik[i, j] = count1++;
                    }
                    else if (i == 1 && j < 2)
                    {
                        matrik[i, j] = count2++;
                    }
                    else if (i == 2 && j < 3)
                    {
                        matrik[i, j] = count3++;
                    }
                    else if (i == 3 && j < 4)
                    {
                        matrik[i, j] = count4++;
                    }
                    else if (i == 4 && j < 5)
                    {
                        matrik[i, j] = count5++; 
                    }
                }
            }
            return matrik;
        }

        //Menggunakan Methode
        public static void NumberEightMat2M(int baris, int column)
        {
            int[,] matrik = new int[baris, column];
            int count1 = 1;
            int count2 = 2;
            int count3 = 3;
            int count4 = 4;
            int count5 = 5;
            int n = column - 1;

            for (int i = 0; i < matrik.GetLength(0); i++)
            {
                for (int j = 0; j < matrik.GetLength(1); j++)
                {
                    if (i == 0 && j <1)
                    {
                        matrik[i, j] = count1++;
                        Console.Write($"{matrik[i, j]}\t");
                    }
                    else if (i == 1 && j < 2)
                    {
                            matrik[i, j] = count2++;
                        Console.Write($"{matrik[i, j]}\t");
                    }
                    else if (i == 2 && j < 3)
                    {
                            matrik[i, j] = count3++;
                            Console.Write($"{matrik[i, j]}\t");
                    }
                    else if (i == 3 && j < 4)
                    {
                            matrik[i, j] = count4++;
                            Console.Write($"{matrik[i, j]}\t");
                    }
                    else if (i == 4 && j < 5)
                    {
                        matrik[i, j] = count5++;
                        Console.Write($"{matrik[i, j]}\t");
                    }
                    else 
                    {
                        Console.Write($"\t");
                    }


                }
                Console.WriteLine();
            }
 
        }

        //Use Methode
        public static void NumberEightMat3M(int baris, int column)
        {
            int[,] matrik = new int[baris, column];
            int count1 = 1;
            int count2 = 1;
            int count3 = 1;
            int count4 = 1;
            int count5 = 1;
            int count6 = 1;
            int count7 = 1;
            int n = column - 1;

            for (int i = 0; i < matrik.GetLength(0); i++)
            {
                for (int j = 0; j < matrik.GetLength(1); j++)
                {
                    if (i == 0 && j < 1)
                    {
                        matrik[i, j] = count1++;
                        Console.Write($"{matrik[i, j]}\t");
                    }
                    else if (i == 1 && j < 2)
                    {
                        matrik[i, j] = count2++;
                        Console.Write($"{matrik[i, j]}\t");
                    }
                    else if (i == 2 && j < 3)
                    {
                        matrik[i, j] = count3++;
                        Console.Write($"{matrik[i, j]}\t");
                    }
                    else if (i == 3 && j < 4)
                    {
                        matrik[i, j] = count4++;
                        Console.Write($"{matrik[i, j]}\t");
                    }
                    else if (i == 4 && j < 3)
                    {
                        matrik[i, j] = count5++;
                        Console.Write($"{matrik[i, j]}\t");
                    }
                    else if (i == 5 && j < 2)
                    {
                        matrik[i, j] = count6++;
                        Console.Write($"{matrik[i, j]}\t");
                    }
                    else if (i == 6 && j < 1)
                    {
                        matrik[i, j] = count7++;
                        Console.Write($"{matrik[i, j]}\t");
                    }
                    else
                    {
                        Console.Write($"\t");
                    }
                }
                Console.WriteLine();
            }
          }

        //Use Funtion
        public static int [,] NumberEightMat3(int baris, int column)
        {
            int[,] matrik = new int[baris, column];
            int count1 = 1;
            int count2 = 1;
            int count3 = 1;
            int count4 = 1;
            int count5 = 1;
            int count6 = 1;
            int count7 = 1;
            int n = column - 1;

            for (int i = 0; i < matrik.GetLength(0); i++)
            {
                for (int j = 0; j < matrik.GetLength(1); j++)
                {
                    if (i == 0 && j < 1)
                    {
                        matrik[i, j] = count1++;
                    }
                    else if (i == 1 && j < 2)
                    {
                        matrik[i, j] = count2++;
                    }
                    else if (i == 2 && j < 3)
                    {
                        matrik[i, j] = count3++;
                    }
                    else if (i == 3 && j < 4)
                    {
                        matrik[i, j] = count4++;
                    }
                    else if (i == 4 && j < 3)
                    {
                        matrik[i, j] = count5++;
                    }
                    else if (i == 5 && j < 2)
                    {
                        matrik[i, j] = count6++;
                    }
                    else if (i == 6 && j < 1)
                    {
                        matrik[i, j] = count7++;
                    }
                }
            }
            return matrik;

        }
        //Use Methode
        public static void NumberEightMat4M(int baris, int column)
        {
            int[,] matrik = new int[baris, column];
            int count1  = 1;
            int count2  = 2;
            int count2r = 4;
            int count3  = 4;
            int count5  = 5;
            int count5r = 8;
            int n = column - 1;

            for (int i = 0; i < matrik.GetLength(0); i++)
            {
                for (int j = 0; j < matrik.GetLength(1); j++)
                {
                    if (i == 0 && j == 4)
                    {
                        matrik[i, j] = count1++;
                        Console.Write($"\t\t\t\t{matrik[i, j]}");
                    }
                    else if (i == 1)
                    {
                        if (j == 3)
                        {
                            matrik[i, j] = count1++;
                            Console.Write($"\t\t\t{matrik[i, j]}\t");
                        }
                        else if (j == 4)
                        {
                            matrik[i, j] = count1++;
                            Console.Write($"{matrik[i, j]}\t");
                        }
                        else if (j == 5)
                        {
                            matrik[i, j] = count2++;
                            Console.Write($"{matrik[i, j]}\t");
                        }
                    }                 
                    else if (i == 2)
                    {
                        if (j == 1)
                        {
                            Console.Write($"\t\t");
                            matrik[i, j] = count2++;
                            Console.Write($"{matrik[i, j]}\t");
                        }
                        if (j == 2)
                        {
                            matrik[i, j] = count2++;
                            Console.Write($"{matrik[i, j]}\t");
                        }
                        if (j == 3)
                        {
                            matrik[i, j] = count2++;
                            Console.Write($"{matrik[i, j]}\t");
                        }
                        if (j ==5)
                        {
                            matrik[i, j] = count2r--;
                            Console.Write($"{matrik[i, j]}\t");
                        }
                        if (j == 6)
                        {
                            matrik[i, j] = count2r--;
                            Console.Write($"{matrik[i, j]}\t");
                        }
                    }
                    else if (i == 3)
                    {
                        if (j == 1)
                        {
                            Console.Write($"\t");
                            matrik[i, j] = count3++;
                            Console.Write($"{matrik[i, j]}\t");
                        }
                        if (j == 2)
                        {
                            matrik[i, j] = count3++;
                            Console.Write($"{matrik[i, j]}\t");
                        }
                        if (j == 3)
                        {
                            matrik[i, j] = count3++;
                            Console.Write($"{matrik[i, j]}\t");
                        }
                        if (j == 4)
                        {
                            matrik[i, j] = count3++;
                            Console.Write($"{matrik[i, j]}\t");
                        }
                        else if (j == 5)
                        {
                            matrik[i, j] = 6;
                            Console.Write($"{matrik[i, j]}\t");
                        }
                        else if (j == 6)
                        {
                            matrik[i, j] = 5;
                            Console.Write($"{matrik[i, j]}\t");
                        }
                        else if (j == 7)
                        {
                            matrik[i, j] = 4;
                            Console.Write($"{matrik[i, j]}\t");

                        }
                    }
                    else if (i == 4)
                    {
                        if (j >= 0 && j <= 4)
                        {
                            matrik[i, j] = count5++;
                            Console.Write($"{matrik[i, j]}\t");
                        }
                        if (j >= 5)
                        {
                            matrik[i, j] = count5r--;
                            Console.Write($"{matrik[i, j]}\t");
                        }
                    }
                    else if (i == 4)
                    {
                            Console.Write($"\t");
                    }
                }
                Console.WriteLine();
            }
        }

        //Use Funtion
        public static int[,] NumberEightMat4(int baris, int column)
        {
            int[,] matrik = new int[baris, column];
            int count1 = 1;
            int count2 = 2;
            int count4 = 4;
            int count5 = 5;
            int count5r = 8;
            int n = column - 1;

            for (int i = 0; i < matrik.GetLength(0); i++)
            {
                for (int j = 0; j < matrik.GetLength(1); j++)
                {
                    if (i == 0 && j == 4)
                    {
                        matrik[i, j] = count1++;
                    }
                    else if (i == 1)
                    {
                        if (j >= 3 && j <= 4)
                        {
                            matrik[i, j] = count1++;
                        }
                        if (j == 5)
                        {
                            matrik[i, j] = count2++;
                        }
                    }
                    else if (i == 2)
                    {
                        if (j >= 2 && j <= 4)
                        {
                            matrik[i, j] = count2++;
                        }
                        if (j == 5)
                        {
                            matrik[i, j] = 4;
                        }
                        if (j == 6)
                        {
                            matrik[i, j] = 3;
                        }
                    }
                    else if (i == 3)
                    {
                        if (j >= 1 && j <= 4)
                        {
                            matrik[i, j] = count4++;
                        }
                        else if (j == 5)
                        {
                            matrik[i, j] = 6;
                        }
                        else if (j == 6)
                        {
                            matrik[i, j] = 5;
                        }
                        else if (j == 7)
                        {
                            matrik[i, j] = 4;
                        }
                    }
                    else if (i == 4)
                    {
                        if (j >= 0 && j <= 4)
                        {
                            matrik[i, j] = count5++;
                        }
                        if (j >= 5)
                        {
                            matrik[i, j] = count5r--;
                        }
                    }
                }
            }
            return matrik;

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