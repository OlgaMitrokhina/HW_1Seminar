// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите 2 числа и программа определит, какое из них больше");
int a, b;

Console.WriteLine("Введите первое число: ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
Console.WriteLine($"Число {a} большее,число {b} меньшее");
}
if (a < b)
{
Console.WriteLine($"Число {b} большее, число {a} меньшее");
}
if (a == b)
{
Console.WriteLine($"Числа {a} и {b} равны ");
}