/*using static System.Console;
using DAY05;

var myArray = Arrays.InitArraysInt(new int[] { 10, 20, 30, 40, 50 });
var boys = Arrays.InitArraysString(new[] { "asep", "budi", "charlie" });
var arrRandom = Arrays.InitRandomArray(10);

Arrays.DisplayArrayInt(myArray);
WriteLine();
Arrays.DisplayArrayString(boys);

WriteLine();
var total = Arrays.SumAllElement(myArray);
Write($"Total :{total}");

WriteLine();
Arrays.DisplayArrayInt(arrRandom);
var largest = Arrays.FindLargestElement(arrRandom);
var indexOfLargest = Arrays.FindIndexLargest(arrRandom);
WriteLine($"Largest : {largest}");
WriteLine($"Index of Largest : {indexOfLargest}");
WriteLine();
Array.Sort(arrRandom);
WriteLine($"Found at index : {Array.BinarySearch(arrRandom, 25)}");
Arrays.DisplayArrayInt(arrRandom);
Array.Reverse(arrRandom); 
WriteLine();


WriteLine("Before Shift Array");
Arrays.DisplayArrayInt(n);
var shiftArray = QuizSolution.ShiftArray(n);
WriteLine();
WriteLine("After Shift Array");
Arrays.DisplayArrayInt(shiftArray);

/***//* Matrix *//*
Matrix.InitMatrix();
var myMatrix = Matrix.FillRandomMatrix(5, 5);
Matrix.DisplayMatrix(myMatrix);

WriteLine();
var matrixDiagonal = Matrix.MatrixDiagonal(5, 5);
Matrix.DisplayMatrix(matrixDiagonal);

ReadLine();
*/