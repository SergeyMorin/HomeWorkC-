// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Введите M: ");
int aSide = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите N: ");
int bSide = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите K: ");
int cSide = int.Parse(Console.ReadLine()!);

if (aSide * bSide * cSide > 90)
    Console.WriteLine("такой трехмерный массив не возможно заполнить двух значными не повтарающимеся числами");
else
{
    Print3DMatrix(Matrix3d(aSide, bSide, cSide));
}

int[,,] Matrix3d(int a, int b, int c)
{
    bool[] array = new bool[100];
    int[,,] matrix = new int[a, b, c];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(10, 100);
                if (!array[matrix[i, j, k]])
                    array[matrix[i, j, k]] = true;
                else
                    k--;
            }
        }
    }
    return matrix;
}

void Print3DMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({j},{k},{i}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}