// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int [,] matrix1 = GenerateMatrixA ();
PrintMatrix(matrix1);
Console.WriteLine();
int [,] matrix2 = GenerateMatrixB ();
PrintMatrix(matrix2);
Console.WriteLine();
PrintMatrix(ProductMatrix (matrix1, matrix2));

int[,] GenerateMatrixA ()
{
    int[,] matrix = new int[2,3];
        for (int m = 0 ; m < matrix.GetLength(0) ; m++)
        {
            for (int n = 0 ; n < matrix.GetLength(1) ; n++)
            {
                matrix[m, n] = new Random().Next(1,10);
            }
        }
    return matrix;  
}

int[,] GenerateMatrixB ()
{
    int[,] matrix = new int[3,2];
        for (int m = 0 ; m < matrix.GetLength(0) ; m++)
        {
            for (int n = 0 ; n < matrix.GetLength(1) ; n++)
            {
                matrix[m, n] = new Random().Next(1,10);
            }
        }
    return matrix;  
}
int [,] ProductMatrix (int [,] MatrixA, int[,]MatrixB)
{
    int [,] productMatrixAB = new int [MatrixA.GetLength(0),MatrixB.GetLength(1)];
    for (int i = 0; i < MatrixA.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixB.GetLength(1); j++)
        {
                for (int n = 0; n < MatrixA.GetLength(1); n++)
                {
                    productMatrixAB[i,j] += MatrixA[i,n] * MatrixB[n,j];
                }
        }
    }
    return productMatrixAB;
}

void PrintMatrix (int [,] Matrix)
{
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            Console.Write(Matrix[i,j]+" ");
        }
        Console.WriteLine();
    }
}