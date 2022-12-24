// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Матрицу из скольки строк M и столбцов N создать?\n Введите M: ");
int mUserInput = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите N:");
int nUserInput = int.Parse(Console.ReadLine()!);
Console.WriteLine("min: ");
int minUserInput = int.Parse(Console.ReadLine()!);
Console.WriteLine("max: ");
int maxUserInput = int.Parse(Console.ReadLine()!);
Console.WriteLine();
double[,] arrayUser = CreateMatrix(mUserInput, nUserInput, minUserInput, maxUserInput);
PrintMatrix(arrayUser);
Console.WriteLine();
Console.WriteLine(SmallestString(arrayUser));

double[,] CreateMatrix(int m, int n, int min, int max)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round((max - min) * new Random().NextDouble() + min, 2);
        }
    }
    return array;
}

void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

double SmallestString(double[,] array)
{
    double[] sumString = new double[array.GetLength(0)];
    double min;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumString[i] += array[i, j];
            if (i == 0)
                min = sumString[i];
        }
        if (sumString[i] < min)
            min = sumString[i];

    }
    return min;
}