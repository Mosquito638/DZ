// Задача 21

// Напишите программу, которая принимает на 
// вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Первый способ с помощью массивов:
// Console.Write("Введите пятизначное число: ");
// double[] num = new double[5] {Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()),
// Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())};
// if (num[0] == num[4] & num[1] == num[3])
// {
//     Console.WriteLine($"{num[0]}{num[1]}{num[2]}{num[3]}{num[4]} -> Да");
// }
// else
// {
//     Console.WriteLine($"{num[0]}{num[1]}{num[2]}{num[3]}{num[4]} -> Нет");
// }

// Второй способ:

// Console.Write("Введите поочередно пять цифр: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());
// int d = Convert.ToInt32(Console.ReadLine());
// int f = Convert.ToInt32(Console.ReadLine());
// if (a == f & b == d)
// {
//     Console.WriteLine($"{a}{b}{c}{d}{f} -> Да");
// }
// else
// {
//     Console.WriteLine($"{a}{b}{c}{d}{f} -> Нет");
// }

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Введите координаты первой точки: ");
// double[] t1 = new double[3] { Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()) };

// Console.Write("Введите координаты второй точки: ");
// double[] t2 = new double[3] { Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()) };

// Console.WriteLine($"t1({t1[0]},{t1[1]},{t2[2]}); t2({t2[0]},{t2[1]},{t2[2]}) -> {Math.Sqrt( (Math.Pow((t2[0] - t1[0]),2)) + (Math.Pow((t2[1] - t1[1]),2)) + (Math.Pow((t2[2] - t1[2]),2)))}");


// Задача 23

// Напишите программу, которая принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// 1й способ:
// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int count = 1;

// Console.Write((a) + " -> ");
// while (count <= a)
// {
//     if (count != a)
//         Console.Write($" {Math.Pow(count, 3)},");


//     else
//         Console.Write($" {Math.Pow(count, 3)}.");
//     count = count + 1;
// }

// второй способ:
// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write((a) + " -> ");

// for (int count = 1; count<a+1; count++ )
// {
//     Console.Write($"{Math.Pow(count, 3)}, ");
// }
