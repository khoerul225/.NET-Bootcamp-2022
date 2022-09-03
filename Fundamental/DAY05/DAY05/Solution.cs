namespace Quiz02
{
    class Solution
    {
        public static void ReadInt(int[] arr15)
        {
            for (int i = 0; i < arr15.Length; i++)
            {
                Console.Write($"{arr15[i]} ");

            }
            Console.WriteLine();
        }
        public static void ReadChar(char[] arr15)
        {
            for (int i = 0; i < arr15.Length; i++)
            {
                Console.Write($"{arr15[i]} ");

            }
            Console.WriteLine();
        }
        public static int[] leftShiftInt(int[] arr15)
        {
            int[] shiftedArray = new int[arr15.Length];
            for (int i = 0; i < arr15.Length; i++)
            {
                if (i == arr15.Length - 1)
                {
                    shiftedArray[i] = arr15[0];
                }
                else
                {
                    shiftedArray[i] = arr15[i + 1];
                }
            }
            return shiftedArray;
        }



        public static int[] RandomPosition(int[] arr15)
        {
            int[] array = arr15;
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int j = random.Next(0, arr15.Length);
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
            return array;
        }

        public static void Soal1(int[] arr15)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Before Random Position");
            ReadInt(arr15);
            Console.WriteLine("After Random Position change");
            arr15 = RandomPosition(arr15);
            ReadInt(RandomPosition(arr15));
            Console.WriteLine("-----------------------");
            Console.WriteLine();
        }

        public static void Soal3(int[] arr15)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Rotate Shifting 3x");
            ReadInt(arr15);
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Rotate ke {i} :");
                ReadInt(leftShiftInt(arr15));
                arr15 = leftShiftInt(arr15);
                Console.WriteLine("-----------------------");
            }
            Console.WriteLine();
        }


        public static int[] rightShiftInt(int[] arr15)
        {
            int[] shiftedArray = new int[arr15.Length];
            for (int i = 0; i < arr15.Length; i++)
            {
                if (i == 0)
                {
                    shiftedArray[i] = arr15[arr15.Length - 1];
                }
                else
                {
                    shiftedArray[i] = arr15[i - 1];
                }
            }
            return shiftedArray;
        }

        public static void Soal2(int[] arr15)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Before Shifting");
            ReadInt(arr15);
            Console.WriteLine("After Shifting");
            ReadInt(leftShiftInt(arr15));
            Console.WriteLine("-----------------------");
            Console.WriteLine();
        }

        public static void Soal4(int[] arr15)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Rotate Shifting 3x");
            ReadInt(arr15);
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Rotate ke {i} :");
                ReadInt(rightShiftInt(arr15));
                arr15 = rightShiftInt(arr15);
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine();
        }
        public static void Soal5(int[] arr15)
        {
            Console.WriteLine("-----------------------");
            ReadInt(arr15);
            Array.Sort(arr15);
            int count = 1;
            for (int i = 0; i < arr15.Length; i++)
            {
                int x = arr15[i];
                if (i < arr15.Length - 1 && x == arr15[i + 1])
                {
                    count++;
                }
                else if (i == arr15.Length - 1 && x == arr15[i - 1])
                {
                    Console.WriteLine($"{arr15[i]} muncul {count} kali");
                }
                else
                {
                    Console.WriteLine($"{arr15[i]} muncul {count} kali");
                    count = 1;
                }
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine();
        }
        public static void Soal6(int[] arr15)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Before Marker");
            ReadInt(arr15);
            Console.WriteLine("After Marker");
            Array.Sort(arr15);
            for (int i = 0; i < arr15.Length; i++)
            {
                int x = arr15[i];
                if (i < arr15.Length - 1 && x == arr15[i + 1])
                {
                    for (int j = i; j < arr15.Length; j++)
                    {
                        if (j == arr15.Length - 1)
                        {
                            arr15[j] = -1;
                        }
                        else
                        {
                            arr15[j] = arr15[j + 1];
                        }
                    }
                }
            }
            ReadInt(arr15);
            Console.WriteLine("-----------------------");
            Console.WriteLine();
        }
        public static void Soal7(int[] arr15)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Before Remove");
            ReadInt(arr15);
            Console.WriteLine("After Remove Duplicate");
            Array.Sort(arr15);
            for (int i = 0; i < arr15.Length; i++)
            {
                int x = arr15[i];
                if (i < arr15.Length - 1 && x == arr15[i + 1])
                {
                    continue;
                }
                Console.Write($"{arr15[i]} ");
            }
            Console.WriteLine();
        }
        public static void Soal8()
        {
            Console.WriteLine("-----------------------");
            var alpa = "abcdefghijklmnopqrstuvwxyz";
            Random rand = new Random();
            char[] arr15 = new char[100];
            for (int i = 0; i < 100; i++)
            {
                arr15[i] = alpa[rand.Next(0, 26)];
            }
            ReadChar(arr15);
            Console.WriteLine("---------Result--------");
            Array.Sort(arr15);
            int count = 1;
            for (int i = 0; i < arr15.Length; i++)
            {
                int x = arr15[i];
                if (i < arr15.Length - 1 && x == arr15[i + 1])
                {
                    count++;
                }
                else if (i == arr15.Length - 1 && x == arr15[i - 1])
                {
                    Console.Write($"{count} {arr15[i]} ");
                }
                else
                {
                    Console.Write($"{count} {arr15[i]} ");
                    count = 1;
                }
            }
            Console.WriteLine();
        }
        public static void DisplayMatrix(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {

                    Console.Write($"{mat[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        public static void DisplayMatrixChar(char[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                Console.Write($"Student{i}\t");
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"{mat[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        public static void Soal9()
        {
            int[,] mat = new int[5, 5];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (j == i)
                    {
                        mat[i, j] = mat.GetLength(1) - j;
                    }
                    else if (j < i)
                    {
                        mat[i, j] = 10;
                    }
                    else
                    {
                        mat[i, j] = 20;
                    }
                }
            }
            Console.WriteLine("----------------------------------");
            DisplayMatrix(mat);
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
        }
        public static void Soal10()
        {
            int[,] mat = new int[5, 5];
            Random r = new Random();
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = r.Next(0, 101);
                }
            }
            DisplayMatrix(mat);
            int diagonalSum = 0;
            Console.WriteLine("----------------------------------");
            Console.Write($"Diagonal: ");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (i == j || i == mat.GetLength(1) - j - 1)
                    {
                        Console.Write($"{mat[i, j]}; ");
                        diagonalSum += mat[i, j];
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Diagonal Sum Value {diagonalSum}");
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
        }
        public static void Soal11()
        {
            Console.Write("Masukan Panjang Matrix: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] mat = new int[n, n];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (i == 0 || i == mat.GetLength(0) - 1)
                    {
                        mat[i, j] = i + j;
                        Console.Write($"{mat[i, j]}\t");
                    }
                    else if (j == 0 || j == mat.GetLength(1) - 1)
                    {
                        mat[i, j] = i + j;
                        Console.Write($"{mat[i, j]}\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------");
            Console.WriteLine();
        }
        public static void Soal12()
        {
            Console.Write("Masukan Panjang Matrix: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] mat = new int[n + 1, n + 1];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (i == mat.GetLength(0) - 1)
                    {
                        int sum = 0;
                        for (int x = 0; x < i; x++)
                        {
                            sum += mat[x, j];

                        }
                        mat[i, j] = sum;
                    }
                    else if (j == mat.GetLength(0) - 1)
                    {
                        int sum = 0;
                        for (int x = 0; x < j; x++)
                        {
                            sum += mat[i, x];

                        }
                        mat[i, j] = sum;
                    }
                    else
                    {
                        mat[i, j] = i + j;
                    }
                }
            }
            mat[n, n] = mat[n, n / 2];
            DisplayMatrix(mat);
            Console.WriteLine("-------------------");
            Console.WriteLine();
        }
        public static void Soal13()
        {
            Console.Write("Masukan Panjang Matrix: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] mat = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //diagonal, semakin ke kanan semakin besar
                    if (j == n - i - 1)
                    {
                        mat[i, j] = j;
                    }
                    //kanan, semakin ke bawah semakin besar
                    else if (j == n - 1)
                    {
                        mat[i, j] = i + j;
                    }
                    //bawah, semakin ke kiri semakin besar
                    else if (i == n - 1)
                    {
                        //keliling segitiga - j
                        mat[i, j] = ((n - 1) * 3) - (j);
                    }
                    else
                    {
                        mat[i, j] = 0;
                    }
                }
            }
            /*Console.WriteLine("Matrix Awal:");
            DisplayMatrix(mat);*/
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //area dibawah diagonal
                    if (j >= n - i - 1)
                    {
                        //setiap isi matrix kelipatan 4 diubah menjadi 3
                        if ((mat[i, j] + 1) % 4 == 0)
                        {
                            mat[i, j] = 3;
                            Console.Write($"{mat[i, j]}\t");
                        }
                        //tengah kosong
                        else if (mat[i, j] == 0 && j != n - i - 1)
                        {
                            Console.Write("\t");
                        }
                        //selain kelipatan 4, dikali 3
                        else
                        {
                            int x = mat[i, j] - (mat[i, j] / 4);
                            mat[i, j] = 2 + (3 * x);
                            Console.Write($"{mat[i, j]}\t");
                        }
                    }
                    //area diatas diagonal kosong
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------");
            Console.WriteLine();
        }
        public static void Soal14()
        {
            Console.Write("Masukan Panjang Matrix: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] mat = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == n - 1)
                    {
                        //semakin ke kanan dan bawah, semakin besar
                        mat[i, j] = i + j;
                    }
                    else if (i == n - 1 || j == 0)
                    {
                        //semakin ke kiri atas, semakin besar
                        mat[i, j] = ((n - 1) * 4) - (i + j);
                        //keliling matrix - (i+j)
                    }
                    else
                    {
                        mat[i, j] = 0;
                    }
                }
            }
            /*Console.WriteLine("Matrix Awal:");
            DisplayMatrix(mat);*/
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //setiap isi matrix kelipatan 4 diubah menjadi 3
                    if ((mat[i, j] + 1) % 4 == 0)
                    {
                        mat[i, j] = 3;
                        Console.Write($"{mat[i, j]}\t");
                    }
                    else if (i > 0 && i < n - 1 && j > 0 && j < n - 1)
                    {
                        //tengah kosong
                        Console.Write("\t");
                    }
                    else
                    {
                        //selain kelipatan 4, dikali 3
                        int x = mat[i, j] - (mat[i, j] / 4);
                        mat[i, j] = 2 + (3 * x);
                        Console.Write($"{mat[i, j]}\t");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------");
            Console.WriteLine();
        }


        public static void Soal15()
        {
            char[,] arr15 = {
                 { 'A','B','A','C','C','D','E','E','A','D'},
                 { 'D','B','A','B','C','A','E','E','A','D'},
                 { 'E','D','D','A','C','B','E','E','A','D'},
                 { 'C','B','A','E','D','C','E','E','A','D'},
                 { 'A','B','D','C','C','D','E','E','A','D'},
                 { 'B','B','E','C','C','D','E','E','A','D'},
                 { 'B','B','A','C','C','D','E','E','A','D'},
                 { 'E','B','E','C','C','D','E','E','A','D'},
                 };
            int count = 0;
            Console.WriteLine("-------INI NO15---------");
            DisplayMatrixChar(arr15);
            char[] kunci = { 'D', 'B', 'D', 'C', 'C', 'D', 'A', 'E', 'A', 'D' };
            Console.WriteLine();
            Console.Write("Kunci Jawaban:\t");
            for (int i = 0; i < kunci.Length; i++)
            {
                Console.Write($"{kunci[i]}\t");
            }
            Console.WriteLine();
            for (int i = 0; i < arr15.GetLength(0); i++)
            {
                for (int j = 0; j < arr15.GetLength(1); j++)
                {
                    if (arr15[i, j] == kunci[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine($"Jawaban siswa {i} yang benar: {count}");
                count = 0;
            }

        }
    }
}