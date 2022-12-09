// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

int[,] array = new int[number, 2];

for (int i = 0; i < number; i++)
{
    array[i, 0] = i + 1;
    array[i, 1] = (i + 1) * (i + 1) * (i + 1);
    Console.WriteLine($"{array[i, 0]} в кубе, это - {array[i, 1]}");
}
