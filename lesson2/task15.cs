// Задача 15. Напишите программу, которая принимает на вход цифру,обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели(1-7)");
int num1 = int.Parse(Console.ReadLine()!);

if (num1 > 0 && num1 < 8)
{
    if (num1 == 6 || num1 == 7)
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Будний");
    }
}
else
{
    Console.WriteLine("Вы ввели число выходящие за диапазон от 1 до 7");
}
