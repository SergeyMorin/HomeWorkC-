// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// Размер массива, минимальное значение и максимальное значение вводим через консоль
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Write("Массив из скольки элементов требуется сгенерировать? ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Минимальное значение элементов массива: ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Максимальное значение элементов массива: ");
int max = int.Parse(Console.ReadLine()!);
Console.WriteLine(Method(n, min, max));
int Method(int i, int mn, int mx)
{
    int x = 0;
    int[] array = new int[i];
    Random random = new Random();
    Console.Write("[ ");
    for (i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(mn, mx + 1);
        Console.Write($"{array[i]} ");
        if (i % 2 != 0)
            x += array[i];
    }
    Console.Write("] -> ");
    return x;
}