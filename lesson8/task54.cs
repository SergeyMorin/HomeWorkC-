// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
SortArray(arrayUser);
PrintMatrix(arrayUser);

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

double[,] SortArray(double[,] array)
{
    double temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if (array[i, j + 1] < array[i, j])
            {
                temp = array[i, j];
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = temp;
                if (j > 0)
                {
                    for (int jndex = j; jndex > 0; jndex--)
                    {
                        if (array[i, jndex] < array[i, jndex - 1])
                        {
                            temp = array[i, jndex - 1];
                            array[i, jndex - 1] = array[i, jndex];
                            array[i, jndex] = temp; 
                        }

                    }
                }
            }
        }
    }
    return array;
}