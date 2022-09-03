using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY05
{
    internal class Matrix
    {
        public static void InitMatrix()
        {
            int[,] matrix = new int[5, 5];
            matrix[2, 2] = 125;
           // Console.WriteLine(matrix);
        }

        public static int[,] FillRandomMatrix(int baris, int kolom)
        {
            int[,]matrix = new int[baris, kolom];
            Random random = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++) // i = baris
            {
                for (int j = 0; j < matrix.GetLength(1); j++)// j= kolom
                {
                    matrix[i, j] = random.Next(20);
                }
            }

            return matrix;
        }


        public static int[,] MatrixDiagonal(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            int counter=0; 

            // fill matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // isi diagonal
                    if (i == j)
                    {
                        matrix[i, j] = counter++;   
                    }else if (j > i)
                    {
                        matrix[i, j] = 10;
                    }else if (i > j)
                    {
                        matrix[i, j] = 20;
                    }
                }
            }
            return matrix;
        }
        public static void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++) // looping baris
            {
                for (int j = 0; j < matrix.GetLength(1); j++)//loop kolom
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
