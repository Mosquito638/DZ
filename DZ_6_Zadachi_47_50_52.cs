
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// double[,] RandArr( int lineLength, int columnLength)         //в параметры задаем значения строк и столбцов 
// {
//     double[,] arr = new double[lineLength, columnLength];
//     for (int i = 0; i < lineLength; i++)
//     {
//         for (int j = 0; j < columnLength; j++)
//         {
//             arr[i, j] = new Random().NextDouble()*100;     
             
//         }

//     }
//     return arr;
// }
// double[,] arr = RandArr(5, 5);           // выводим на консоль
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         Console.Write($"{Math.Round((arr[i, j]), 2)} "); 
//     }
//     Console.WriteLine();
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// int[,] RandArr(int minline, int maxline, int mincolumn,   // создаем метод для рандомного заполнения двумерного массива
//  int maxcolumn, int lineLength, int columnLength)         //в параметры задаем мин и макс значения строк и столбцов, а так же их длину 
// {
//     int[,] arr = new int[lineLength, columnLength];
//     for (int i = 0; i < lineLength; i++)
//     {
//         for (int j = 0; j < columnLength; j++)
//         {
//             arr[i, j] = new Random().Next(minline, maxline);      // Next не дала впихнуть более чем 2 аргумента, поэтому 2 раза Next делаю.
//             arr[i, j] = new Random().Next(mincolumn, maxcolumn); // Станислав, может как то можно в 1 строчку сделать?? 
//         }

//     }
//     return arr;
// }

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int[,] arr = RandArr(-5, 5, -5, 5, 3, 3);           // Есс! Метод работает!!!!!
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         Console.Write($"{arr[i, j]} ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();


// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//     //    while (arr[i,j] !=N)
//     //    {
//     //     arr[i,j] = arr[i+1,j+1];
//         if(arr[i,j] == N)
//             {
//                 Console.Write($"{N} - > такое число есть в массиве "); // Станислав, подскажите, как сделать вывод инфо, что числа нет - 
//                 break;                                                 // у меня зациклевается надпись что его нет и каждый элемент он это показывает
//             }                                                          // Поэтому пришлось вообще убрать вывод - нет! Только выводит если есть
           
     
//     }
//   Console.Write($"{N} ");  
// }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] RandArr(int minline, int maxline, int mincolumn,   // создаем метод для рандомного заполнения двумерного массива
//  int maxcolumn, int lineLength, int columnLength)         //в параметры задаем мин и макс значения строк и столбцов, а так же их длину 
// {
//     int[,] arr = new int[lineLength, columnLength];
//     for (int i = 0; i < lineLength; i++)
//     {
//         for (int j = 0; j < columnLength; j++)
//         {
//             arr[i, j] = new Random().Next(minline, maxline);      // Next не дала впихнуть более чем 2 аргумента, поэтому 2 раза Next делаю.
//             arr[i, j] = new Random().Next(mincolumn, maxcolumn); // Станислав, может как то можно в 1 строчку сделать?? 
//         }

//     }
//     return arr;
// }
// int[,] arr = RandArr(1, 5, 1, 5, 3, 3);           // + на вывод Метод работает!!!!!

// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         Console.Write($"{arr[i, j]} ");
//     }
//     Console.WriteLine();
// }
// double Sum = 0;
// int N = arr.GetLength(1);
// Console.WriteLine();
// for (int j = 0; j < arr.GetLength(1); j++)
// {
//     Sum = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         Console.Write($"{arr[i,j]}; ");
//         Sum = Sum + arr[i,j];
//     }
//     Console.WriteLine($" = {Sum/(arr.GetLength(1))}" );
    
// }
// Console.WriteLine();
