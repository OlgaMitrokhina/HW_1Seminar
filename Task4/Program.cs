﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите 3 числа и программа выдаст максимальное из этих чисел:");
int a, b, c;

Console.WriteLine("Введите первое число: ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max)
{
max = b;
}
if (c>max)
{
    max = c;
}
Console.WriteLine($"Число {max} наибольшее");
    