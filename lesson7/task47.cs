// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Матрицу из скольки строк и столбцов создать?\n Введите количество строк: ");
int lineCountUserInput = int.Parse(Console.ReadLine()!);
Console.WriteLine(" Введите количество стобцов:");
int columnCountUserInput = int.Parse(Console.ReadLine()!);
Console.WriteLine();
double[,] UserMatrix = CreateMatrix(lineCountUserInput, columnCountUserInput, 0, 10);
PrintMatrix(UserMatrix);

double[,] CreateMatrix(int m, int n, int min, int max)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round((max - min) * new Random().NextDouble() + min, 1);
        }
    }
    return array;
}

void PrintMatrix(double[,] matrix)
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