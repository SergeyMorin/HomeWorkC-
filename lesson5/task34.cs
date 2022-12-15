// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// Размер массива вводим через консоль
// [345, 897, 568, 234] -> 2
Console.Write("Массив из скольки элементов требуется сгенерировать? ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(Method(n));
int Method(int i)
{
    int x = 0;
    int[] array = new int[i];
    Random random = new Random();
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 1000);
        if (array[i] % 2 == 0)
            x++;
        Console.Write($"{array[i]} ");
    }
    Console.Write("] -> ");
    return x;
}