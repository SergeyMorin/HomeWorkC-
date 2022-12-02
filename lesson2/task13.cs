// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число больше 99");
string num1 = Console.ReadLine()!;

if (num1[0] == '-')
{
    if (num1.Length >= 4)
    {
        Console.WriteLine(num1[3]);
    }
    else
    {
        Console.WriteLine("число менее трех знаков");
    }
}
else
{
    if (num1.Length >= 3)
    {
        Console.WriteLine(num1[2]);
    }
    else
    {
        Console.WriteLine("число менее трех знаков");
    }
}
