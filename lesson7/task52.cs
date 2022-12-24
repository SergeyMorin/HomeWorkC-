// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Матрицу из скольки строк и столбцов создать?\n Введите количество строк: ");
int lineCountUserInput = int.Parse(Console.ReadLine()!);
Console.WriteLine(" Введите количество стобцов:");
int columnCountUserInput = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int[,] UserMatrix = Generate2DArray(lineCountUserInput, columnCountUserInput);
PrintMatrix(UserMatrix);
Console.WriteLine("\n Среднее арифметическое каждого столбца:");
PrintAverageSummColumn(AverageSummColumn(UserMatrix));

void PrintAverageSummColumn(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

double[] AverageSummColumn(int[,] matrix)
{
    double[] averageSummColumn = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            averageSummColumn[j] += matrix[i, j];
        }
        averageSummColumn[j] /= matrix.GetLength(0);
    }
    return averageSummColumn;
}

int[,] Generate2DArray(int lineCount, int columnCount)
{
    int[,] matrix = new int[lineCount, columnCount];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}