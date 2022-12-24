// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1
// 7 -> такого числа в массиве нет

Console.WriteLine("Матрицу из скольки строк M и столбцов N создать?\n Введите M: ");
int mUserInput = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите N:");
int nUserInput = int.Parse(Console.ReadLine()!);

int [,] userMatrix = Generate2DArray(mUserInput, nUserInput);
Print2DArray(userMatrix);

Console.WriteLine("\n Какой элемент вывести?");
Console.WriteLine("Введите индекс строки:");
int mUserInput2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите индекс строки:");
int nUserinput2 = int.Parse(Console.ReadLine()!);
FindElement(mUserInput2, nUserinput2, userMatrix);

void FindElement(int m, int n, int[,] matrix)
{
    if( m > matrix.GetLength(0)-1 || n > matrix.GetLength(1)-1 || m < 0 || n < 0)
        Console.WriteLine("такого числа в матрице нет");
    else
        Console.WriteLine(matrix[m, n]);
}

int[,] Generate2DArray(int mUserInput, int nUserInput)
{
    
    int[,] matrix = new int[mUserInput,nUserInput];
        for (int m = 0 ; m < matrix.GetLength(0) ; m++)
        {
            for (int n = 0 ; n < matrix.GetLength(1) ; n++)
            {
                matrix[m, n] = new Random().Next(1,10);
            }
        }
    return matrix;  
}

void Print2DArray(int[,] matrixUser)
{
    for (int i = 0; i < matrixUser.GetLength(0); i++)
    {
        for (int j = 0; j < matrixUser.GetLength(1); j++)
        {
            Console.Write(matrixUser[i, j] + " ");
        }
        Console.WriteLine();
    }
}