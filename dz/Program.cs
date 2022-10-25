/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100,100)) / 10;
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] arr = new int[3, 4];
// FillArray(arr);
// PrintArray(arr);

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void Find(int[,] arr, int x, int y)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {

//             if (x == i + 1 && y == j + 1) Console.WriteLine($"Значение элемента в строке {i + 1}: {arr[i, j]}");
//             else if (x != i + 1 && y != j + 1) 
//             {
//                 Console.WriteLine($"Такого элемента нет в {i + 1} строке");
//                 break;}
//         }
//     }
// }

// int[,] arr = new int[3, 4];
// FillArray(arr);
// PrintArray(arr);
// Console.WriteLine();
// Console.Write("Введите число строки - ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число столбца - ");
// int y = Convert.ToInt32(Console.ReadLine());
// Find(arr, x, y);


/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

// Console.Write("Введите кол-во строк - ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов - ");
// int y = Convert.ToInt32(Console.ReadLine());
// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(-9, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j ]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] array = new int [x, y];
// FillArray(array);
// PrintArray (array);
// Console.WriteLine();
// Console.WriteLine("Среднее арифметическое столбцов:");

// double[] average = new double[y];
// for(int j= 0, count = 0; j < y; j++)
// {
//     double sum = 0;
//     for (int i= 0; i < x; i++)
//     {
//         sum +=array[i, j];
//     }
//     average[count] = sum / x;
//     Console.WriteLine($"{Math.Round(average[count], 2)} ");
//     count++;
// }