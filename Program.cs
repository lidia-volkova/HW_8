// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. 
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// В итоге получается вот такой массив: 
// 7 4 2 1 
// 9 5 3 2 
// 8 4 4 2 
 
// int [,] Create2dArray () // создание массива
// { 
//     Console.Write("Введите количество строк: "); 
// int rows = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите количество столбцов: "); 
// int columns = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите наименьшее значение: "); 
// int minVal = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите наибольшее значение: "); 
// int maxVal = Convert.ToInt32(Console.ReadLine()); 
//     int [,] createdArray = new int [rows, columns]; 
//     for (int i = 0; i < rows; i++) 
//     { 
//         for (int j = 0; j < columns; j++) 
//         { 
//             createdArray[i,j] = new Random().Next(minVal, maxVal + 1); 
//         } 
//     } 
//     return createdArray; 
// } 
//  void Show2dArray (int [,] matrix) // вывод массива

// { 
//     for (int i= 0; i< matrix.GetLength(0); i++) 
//     { 
//         for (int j =0; j< matrix.GetLength(1);j++) 
//         { 
//             Console.Write(matrix[i,j] + " "); 
//         } 
//         Console.WriteLine(""); 
//     } 
//     Console.WriteLine(""); 
// } 
// void OrderArrayLines(int[,] array) 
// { 
//   for (int i = 0; i < array.GetLength(0); i++) 
//   { 
//     for (int j = 0; j < array.GetLength(1); j++) 
//     { 
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       { 
//         if (array[i, k] < array[i, k + 1]) 
//         { 
//           int temp = array[i, k + 1]; 
//           array[i, k + 1] = array[i, k]; 
//           array[i, k] = temp; 
//         } 
//       } 
//     } 
//   } 
// } 
 
// int[,] array = Create2dArray(); 
// Show2dArray(array); 
// OrderArrayLines(array); 
// Show2dArray(array);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. 
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// 5 2 6 7 
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка 
 
 
// int [,] Create2dArray () // создание массива
// { 
//     Console.Write("Введите количество строк: "); 
// int rows = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите количество столбцов: "); 
// int columns = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите наименьшее значение: "); 
// int minVal = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите наибольшее значение: "); 
// int maxVal = Convert.ToInt32(Console.ReadLine()); 
//     int [,] createdArray = new int [rows, columns]; 
//     for (int i = 0; i < rows; i++) 
//     { 
//         for (int j = 0; j < columns; j++) 
//         { 
//             createdArray[i,j] = new Random().Next(minVal, maxVal + 1); 
//         } 
//     } 
//     return createdArray; 
// } 

// void Show2dArray (int [,] matrix) // вывод массива

// { 
//     for (int i= 0; i< matrix.GetLength(0); i++) 
//     { 
//         for (int j =0; j< matrix.GetLength(1);j++) 
//         { 
//             Console.Write(matrix[i,j] + " "); 
//         } 
//         Console.WriteLine(""); 
//     } 
//     Console.WriteLine(""); 
// } 
 
// int SumOfLines(int[,] matrix, int i) 
// { 
//   int sumLine = matrix[i,0]; 
//   for (int j = 1; j < matrix.GetLength(1); j++) 
//   { 
//     sumLine = sumLine + matrix[i,j]; 
//   } 
//   return sumLine; 
// } 
 
// int MinLine (int [,] matrix)
// {
// int minSumLine = 0; 
// int sumLine = SumOfLines(matrix, 0); 
// for (int i = 1; i < matrix.GetLength(0); i++) 
// { 
//   int tempSumLine = SumOfLines(matrix, i); 
//   if (sumLine > tempSumLine) 
//   { 
//     sumLine = tempSumLine; 
//     minSumLine = i; 
//   } 
// } 
// return minSumLine;
// }
 
// int[,] array = Create2dArray(); 
// Show2dArray(array); 
// int sum = SumOfLines(array, 0); 
// int min = MinLine (array);
// Console.WriteLine($"наименьшая сумма чисел в строке - {min+1}");



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.  
// Например, на выходе получается вот такой массив: 
// 01 02 03 04 
// 12 13 14 05 
// 11 16 15 06 
// 10 09 08 07 
  
