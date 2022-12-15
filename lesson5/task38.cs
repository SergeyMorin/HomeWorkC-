// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Размер массива, минимальное значение и максимальное значение вводим через консоль
// Для генерации вещественных числе, по аналогии с int, есть функция NextDouble()
// [3 7 22 2 78] -> 76
Console.Write("Массив из скольки элементов требуется сгенерировать? ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Минимальное значение элементов массива: ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Максимальное значение элементов массива: ");
int max = int.Parse(Console.ReadLine()!);
Console.WriteLine(Method(n, min, max));
int Method(int i, int mn, int mx)
{
    int result, mxel = mn, mnel = mx;
    int[] array = new int[i];
    Random random = new Random();
    Console.Write("[ ");
    for (i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(mn, mx + 1);
        if (array[i] > mxel)
            mxel = array[i];
        if (array[i] < mnel)
            mnel = array[i];
        Console.Write($"{array[i]} ");
    }
    Console.Write("] -> ");
    result = mxel - mnel;
    return result;
}