// // Домашние задания:
// // Задача 2: Напишите программу, Которая на вход принимает два числа
// // //  и выдает, какое число большее, а какое меньшее. 

// Console.Write("Введите первое число: ");

// int N_1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");

// int N_2 = Convert.ToInt32(Console.ReadLine());


// if(N_1 > N_2)
// {
//     Console.WriteLine("Большее число:" + N_1);
//     Console.WriteLine("Меньшее число:" + N_2);
// }
// else
// {
//     Console.WriteLine("Большее число:" + N_2);
//     Console.WriteLine("Меньшее число:" + N_1);
// }
// ___________________________________________________________________

// Задача 4: Напишите программу, которая на вход принимает
// 3 числа и выдает максимальное из этих чисел.

// Console.Write("Введите первое число: ");
// int first_num = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int second_num = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите третье число: ");
// int third_num = Convert.ToInt32(Console.ReadLine());

// int max = 0;

// if(first_num > second_num)
// {
//     max = first_num;
// }
// else 
// {
//     max = second_num;
// }    

// if(third_num > max)
// {
//     max = third_num;
// }

// Console.WriteLine("Максимальное число: " + max);
// // _______________________________________________________________

// // Задача 6: Напишите программу, которая на вход принимает число
// //  и выдает является ли число четным (делится ли на 2 без остатка).

// Console.Write("Введите число: ");

// int N = Convert.ToInt32(Console.ReadLine());

// if(N%2 == 1)
// {
//     Console.Write("Число "  +  N  +  " Не чётное");
// }
// else
// {
//     Console.Write("Число "  +  N  +  " Чётное");
// }
// _____________________________________________________________
// Задача 8: Напишите программу, которая на вход принимает число N, а на 
// выходе показывает все четные числа от одного до N.

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int count = 1;

// while(count <= N)
// {
//     if(count%2 == 1)
//     {
//         count = count+1;
//     }
//     else
//     {
//         Console.Write((count) + ",");
//         count = count + 1;
//     }    
// }
