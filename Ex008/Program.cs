// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите натуральное число:");
int numberA = int.Parse(Console.ReadLine());
int count = 2;
if (numberA%2!=0)
{
    numberA = numberA-1;
}
while (count<numberA)
{
    Console.Write($"{count},");
    count = count + 2;
}
Console.Write(count);