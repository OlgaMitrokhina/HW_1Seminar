// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число от 1 до N и программа выведет четные числа из диапазона");
int n;
Console.WriteLine ("Введите число: ");
n = Convert.ToInt32(Console.ReadLine());
while (n <= 0)
{
    Console.WriteLine("Введите целое положительное число от 1: ");
    n = Convert.ToInt32(Console.ReadLine());
}
for (int x = 1; x <= n; x++)
if (x%2==0)
Console.Write(x.ToString() + " ");