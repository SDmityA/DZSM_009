// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// **************** Задача 1*******************************8
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число");
// int num =Convert.ToInt32 (Console.ReadLine());
// string num1=Convert.ToString(num);

// if (num1[0]==num1[4]&&num1[1]==num1[3])
// {
//     Console.WriteLine("Да");
// }
// else Console.WriteLine("Нет");

// *********************конец**********************************
// ************************Задача 2*******************************
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Ввелите координату x для первой точки");
// int x1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ввелите координату y для первой точки");
// int y1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ввелите координату z для первой точки");
// int z1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ввелите координату x для второй точки");
// int x2=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ввелите координату y для второй точки");
// int y2=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ввелите координату z для второй точки");
// int z2=Convert.ToInt32(Console.ReadLine());
// double d=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
// Console.WriteLine(d);

// *************конец**********************************************
// **********************Задача 3**********************************
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// Console.WriteLine("Ввелите число");
// int num=Convert.ToInt32(Console.ReadLine());
// for(int i=1;i<=num;i++)
// {
//     Console.Write(Math.Pow(i,3)+",");
// }
// цикл "while"

// Console.WriteLine("Ввелите число");
// int num=Convert.ToInt32(Console.ReadLine());
// int num1 = 1;
// while (num1<=num)
// {
//     Console.Write(Math.Pow(num1,3)+",");
//     num1++;
// }

// *************конец********************