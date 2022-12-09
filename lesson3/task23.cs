// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

for (int i = 1 ; i <= number ; i++)
{
Console.Write($"{Math.Pow(i, 3)} ");
}