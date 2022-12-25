// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.WriteLine("Матрицу A из скольки строк M и столбцов N создать?\n Введите M: ");
int m1UserInput = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите N:");
int n1UserInput = int.Parse(Console.ReadLine()!);

Console.WriteLine("Матрицу B из скольки строк M и столбцов N создать?\n Введите M: ");
int m2UserInput = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите N:");
int n2UserInput = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int[,] matrix1 = GenerateMatrix(m1UserInput, n1UserInput);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = GenerateMatrix(m2UserInput, n2UserInput);
PrintMatrix(matrix2);
Console.WriteLine();
if (m1UserInput == n2UserInput)
{
    Console.WriteLine("Произведением матрицы A на матриуц B будет матрица AB:");
    PrintMatrix(ProductMatrix(matrix1, matrix2));
}
else
{
    Console.WriteLine("данные матрицы незьзя умножить.");
}

int[,] GenerateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

int[,] ProductMatrix(int[,] MatrixA, int[,] MatrixB)
{
    int[,] productMatrixAB = new int[MatrixA.GetLength(0), MatrixB.GetLength(1)];
    for (int i = 0; i < MatrixA.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixB.GetLength(1); j++)
        {
            for (int n = 0; n < MatrixA.GetLength(1); n++)
            {
                productMatrixAB[i, j] += MatrixA[i, n] * MatrixB[n, j];
            }
        }
    }
    return productMatrixAB;
}

void PrintMatrix(int[,] Matrix)
{
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            Console.Write(Matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}