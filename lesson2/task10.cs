// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает ВТОРУЮ цифру этого числа.

Console.WriteLine("Введите трехзначное число");
int num1 = int.Parse(Console.ReadLine()!);
if ((num1 >= 100) && (num1 < 1000))
{
    int firstDigit = num1 % 100;
    int secondDigit = firstDigit / 10;
    Console.WriteLine(secondDigit);
}
else
{
    Console.WriteLine("Введено не трех значное число");
}
