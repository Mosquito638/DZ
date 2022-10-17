// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// Console.Clear();
// int[,] creatArray(int row, int column)
// {
//     int[,] array = new int[row, column];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }
// void showArray(int[,] array)
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

// int[,] newArr = creatArray(4, 4);
// showArray(newArr);
// Console.WriteLine();



// for (int i = 0; i < newArr.GetLength(0); i++)

// {
//     for (int j = 0; j < newArr.GetLength(1)-1; j++)
//     {
//         for (int k = j+1; k < newArr.GetLength(1); k++)
//         {
//             if(newArr[i,j]<newArr[i,k])
//             {
//             int m = newArr[i,k];
//             newArr[i,k] = newArr[i, j];
//             newArr[i, j] = m;
//             // Console.Write($"{newArr[i, j]} ");
//             }
//         }

//     }
// }
// Console.WriteLine();
// showArray(newArr);




// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// int[,] creatArray(int row, int column)
// {
//     int[,] array = new int[row, column];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }
// void showArray(int[,] array)
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

// int[,] newArr = creatArray(5, 5);
// // showArray(newArr);
// Console.WriteLine();

// int Summ = 0;
// int index = 0;

// for (int i = 0; i < newArr.GetLength(1); i++)
// {
//     Summ = Summ + newArr[0, i];

// }
// Console.WriteLine();

// for (int i = 0; i < newArr.GetLength(0); i++)
// {
//     int Sum2 = 0;

//     for (int j = 0; j < newArr.GetLength(1); j++)
//     {
//         Sum2 = Sum2 + newArr[i, j];
//         Console.Write($"{newArr[i, j]} ");
//     }
//     Console.WriteLine($"({Sum2}) ");

//     if (Sum2 < Summ)
//     {
//         Summ = Sum2;
//         index = i;

//     }

// }

// Console.WriteLine($"{Summ} -> строка {index + 1}");


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.Clear();

// int[,,] creatArray(int row, int column, int depth)
// {
//     int[,,] array = new int[row, column, depth];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int k = 0; k < array.GetLength(2); k++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array[i,j,k] = new Random().Next(10, 100);
//             }

//         }
//     }
//     return array;
// }
// Console.WriteLine();
// void showArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int k = 0; k < array.GetLength(2); k++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                Console.Write($"{array[i,j,k]} ({i},{j},{k}) "); 
//             }
//             Console.WriteLine();
            
//         }
//         Console.WriteLine();
//     }
// }

// int[,,] newArr = creatArray(2, 2, 2);
// showArray(newArr);
// Console.WriteLine();
